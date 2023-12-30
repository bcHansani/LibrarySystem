using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class Home : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        private List<DropDownList> dropDownList = new List<DropDownList>();

        public Home()
        {
            InitializeComponent();
            conn = new SqlConnection(Program.ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT username, password FROM [dbo].[Login]";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    // Bind the DataTable to the DataGridView
                    //dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            ViewAddBookGridView();
        }

        private void btnViewLoans_Click(object sender, EventArgs e)
        {
            ViewAddLoanGridView();
        }

        public void ViewAddBookGridView()
        {
            try
            {
                string query = "SELECT Book_ID, Book_Name, Author,CreationDate  FROM [dbo].[Books]";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    gvBookView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void ViewAddLoanGridView()
        {
            try
            {
                string query = "SELECT LP.Loan_ID," +
                    "LP.Book_ID," +
                    "BK.Book_Name," +
                    "BK.Author," +
                    "LP.Number_of_copies," +
                    "LP.NIC," +
                    "LP.Loan_amount," +
                    "LP.LoanDate" +
                    " FROM [dbo].[Loan_process] LP" +
                    " INNER JOIN [dbo].[BOOKS] BK" +
                    " ON LP.Book_ID = BK.Book_ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    gvLoanView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = tabReservaion.SelectedIndex;

                if (selectedIndex == 1)
                {
                    BindComboBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindComboBooks()
        {
            try
            {
                dropDownList = new List<DropDownList>() {
                    new DropDownList
                    {
                        id = -1,
                        name = "- Select -",
                        commonProp = ""
                    }
                };

                string query = "SELECT Book_ID, Book_Name, Author,CreationDate  FROM [dbo].[Books]";

                cmd.CommandText = query;
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        dropDownList.Add(new DropDownList
                        {
                            id = Convert.ToInt32(rdr["Book_ID"].ToString()),
                            name = rdr["Book_Name"].ToString(),
                            commonProp = rdr["Author"].ToString(),
                        });
                    }
                }

                conn.Close();

                addLoanBook.DataSource = null;
                addLoanBook.DataSource = dropDownList;
                addLoanBook.ValueMember = "id";
                addLoanBook.DisplayMember = "name";
                addLoanBook.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void addLoanBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addLoanBook.SelectedValue == null || addLoanBook.SelectedValue is DropDownList selectedValue)
            {
                return;
            }
            else
            {
                DropDownList selecteddropDownItem = dropDownList.Find(x => x.id == (int)addLoanBook.SelectedValue);

                if (selecteddropDownItem != null)
                {
                    txtloadAuth.Text = selecteddropDownItem.commonProp;
                }
                else
                {
                    txtAddBookAuther.Text = "";
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [dbo].[Books]" +
                                "([Book_Name]" +
                                ",[Author]" +
                                ",[CreationDate])" +
                                " VALUES"
                                + "('" + txtAddBookName.Text + "', '" + txtAddBookAuther.Text + "' ,'" + DateTime.Now + "')";

                cmd.CommandText = query;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book Create success");
                    ViewAddBookGridView();
                }
                else
                {
                    MessageBox.Show("Book Create fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudCoppys.Value == 0)
                {
                    MessageBox.Show("Please select more than 1 coppys");
                    return;
                }

                string query = "INSERT INTO [dbo].[Loan_process]" +
                                "([Book_ID]" +
                                ",[Number_of_copies]" +
                                ",[NIC]" +
                                ",[Loan_amount]" +
                                ",[LoanDate])" +
                                " VALUES"
                                + "('" + (int)addLoanBook.SelectedValue + "', '" + nudCoppys.Value + "', '" + txtLoanNic.Text + "' , '" + txtLoanAmount.Text + "' ,'" + DateTime.Now + "')";

                cmd.CommandText = query;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Loan Create success");
                    ViewAddLoanGridView();
                }
                else
                {
                    MessageBox.Show("Loan Create fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [dbo].[Reservation]" +
                                "([Name]" +
                                ",[Book_Name])" +
                                " VALUES"
                                + "('" + txtName .Text + "', '" + txtBook_name1 .Text + "' ,' )";

            MessageBox.Show("Data successfully saved");
        }
    }
}