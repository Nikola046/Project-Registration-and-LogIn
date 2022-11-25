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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "" && tbpassword.Text == "" && tbconfirmpassword.Text=="")
            {
                MessageBox.Show("Username and Password fields are empty", "Registartion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbpassword.Text == tbconfirmpassword.Text)
            {
                /*Connecting to the database and entering values
                  into database table*/

                string ConnectionString = "Data Source=NIKOLA\\SQLEXPRESS;Initial Catalog=RegLog;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                
                con.Open();
                
                string username = tbusername.Text;
                string password = tbpassword.Text;
                
                string query = "INSERT INTO Users(Username, Password) VALUES('" + username + "' , '" + password + "') ";
                
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                
                con.Close();

                MessageBox.Show("Your Account has been succesfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbusername.Text = "";
                tbpassword.Text = "";
                tbconfirmpassword.Text = "";
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter","Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                tbpassword.Text = "";
                tbconfirmpassword.Text = "";
                tbpassword.Focus();
            }

            
        }

        //checkBox1 is checkbox for "Show password"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbpassword.PasswordChar = '\0';
                tbconfirmpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
                tbconfirmpassword.PasswordChar = '*';
            }
        }

        //Clear text boxes
        private void btnclear_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbpassword.Text = "";
            tbconfirmpassword.Text = "";

            tbusername.Focus();
        }

        private void btnbacktologin_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
