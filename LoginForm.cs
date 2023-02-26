using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankingFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newuserInput_Click(object sender, EventArgs e)
        {
            
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.WindowState = FormWindowState.Minimized;



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
