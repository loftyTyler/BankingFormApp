﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace BankingFormApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\telof\Documents\regDetailsDB.mdf;Integrated Security = True; Connect Timeout = 30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerNewAccountButton_Click(object sender, EventArgs e)
        {
            string name, password, confirmPassword;
            name = regUsernameInput.Text;
            password = passwordInput.Text;
            confirmPassword = passwordConfirmInput.Text;
            LoginForm loginForm = new LoginForm();
            if (confirmPassword == password)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into regDetails values('" + name + "','" + password + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Name:" + name + "\nPassword" + password);
                MessageBox.Show("Record INSERTED successfully...");
                this.Close();
            } else
            {
                MessageBox.Show("Passwords do not match, try again.");
            }

            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
