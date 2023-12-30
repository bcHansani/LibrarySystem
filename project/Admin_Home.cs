using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Admin_Home : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        private List<DropDownList> dropDownList = new List<DropDownList>();
        public Admin_Home()
        {
            InitializeComponent();
            conn = new SqlConnection(Program.ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
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
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {

        }
    }
}
