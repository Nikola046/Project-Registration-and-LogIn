using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registration_and_login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Checking the accuracy of entered data
        private void btnregister_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=NIKOLA\\SQLEXPRESS;Initial Catalog=RegLog;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            
            con.Open();
            
            string username = tbusername.Text;
            string password = tbpassword.Text;
            
            string query = "SELECT *FROM Users WHERE Username='"+username+"' AND Password='"+password+"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                new Form3().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password, Please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                tbusername.Text = "";
                tbpassword.Text = "";
                
                tbusername.Focus();
            }
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbpassword.Text = "";
            tbusername.Focus();
        }

        //checkBox1 is checkbox for "Show password"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }

        private void btnbacktologin_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
