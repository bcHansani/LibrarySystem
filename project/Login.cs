using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project
{
    public partial class Login : Form

    {
        //private const string ConnectionString = @"Data Source=DESKTOP-9USB0H9\SQLEXPRESS;Initial Catalog=LULZ_library;Integrated Security=True";
        
        private SqlConnection conn;
        private SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(Program.ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = "";
                string query = "select username,password from Login where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                cmd.CommandText = query;
                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        userName = rdr["username"].ToString();
                    }
                }
                if (userName != "")
                {
                    MessageBox.Show("Login success");
                    Home nextForm = new Home();
                    this.Hide();
                    nextForm.Show();
                }
                else
                {
                    MessageBox.Show("Login fail");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {
                SignIn nextForm = new SignIn();
                this.Hide();
                nextForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Librariyan nextForm = new Librariyan();
            this.Hide();
            nextForm.Show();
        }
    }
}