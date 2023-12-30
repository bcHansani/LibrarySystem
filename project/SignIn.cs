using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class SignIn : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public SignIn()
        {
            InitializeComponent();
            conn = new SqlConnection(Program.ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [dbo].[Login]" +
                                "([username]" +
                                ",[password])" +
                                " VALUES" + "('" + textBox1.Text + "', '" + textBox2.Text + "')";

                cmd.CommandText = query;
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account Create success");
                }
                else
                {
                    MessageBox.Show("Account Create fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login nextForm = new Login();
                this.Hide();
                nextForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}