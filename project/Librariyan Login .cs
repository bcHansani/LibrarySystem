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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class Librariyan : Form
    {
        //private const string ConnectionString = @"Data Source=DESKTOP-9USB0H9\SQLEXPRESS;Initial Catalog=LULZ_library;Integrated Security=True";

        private SqlConnection conn;
        private SqlCommand cmd;
        public Librariyan()
        {
            InitializeComponent();
            conn = new SqlConnection(Program.ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;

        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string  userName = "";
                    string query = "select username,password from Login where username='" + txtLibrariyan_username.Text + "'and password='" + Librariyan_password.Text + "'and registered_as='admin'";
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
        }
    }
}
