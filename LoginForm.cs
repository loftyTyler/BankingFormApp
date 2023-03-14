using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            //This code will activate Registration Form
            RegistrationForm regForm = new RegistrationForm();
            this.Hide();
            regForm.ShowDialog();
            this.Show();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {                  
            
        }

     
        public class LoginFormData
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string FullName { get; set; }
            public decimal AccountBalance { get; set; }
        }
        //Initiliazation of Variables for Global Use
        public static string name;
        public static string password;
        
        
        private void signInSubmit_Click(object sender, EventArgs e)
        {
           
            //This code will create an instance of AccountDetails so it can show the AccountDetails Form
            AccountDetails accountForm = new AccountDetails();
            //Giving name and password the user inputed values
            name = usernameInput.Text;
            password = passwordInput.Text;
            
            using (databaseTestingEntities db = new databaseTestingEntities())
            {

                foreach (var prod in db.databaseTestings)
                {

                    if (name == prod.name)
                    {
                        if (password == prod.password)
                        {
                            MessageBox.Show("Login Successful!");
                            accountForm.Show();
                            this.WindowState = FormWindowState.Minimized;
                        }
                        else
                        {
                            MessageBox.Show("Wrong Info");
                        }

                    }
                }
            }
        }       
    }
}
