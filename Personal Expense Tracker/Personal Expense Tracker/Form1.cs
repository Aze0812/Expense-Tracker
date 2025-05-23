using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Personal_Expense_Tracker
{
    public partial class Form1: Form
    {
        string sqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Zeji\Documents\XpenseDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
        //login button
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbZ = new SqlConnection(sqlConnection))
            {
                dbZ.Open();

                string selectData = "SELECT * FROM Users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(selectData, dbZ))
                {
                    cmd.Parameters.AddWithValue("@usern", LoginText1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", LoginPass1.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);    

                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login Credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            regform.Show();
            this.Hide();
        }



        private void LoginPass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoginPass1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
