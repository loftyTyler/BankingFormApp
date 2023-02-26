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


namespace BankingFormApp
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\telof\Documents\regDetailsDB.mdf;Integrated Security = True; Connect Timeout = 30");

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newuserInput_Click(object sender, EventArgs e)
        {
            
            RegistrationForm regForm = new RegistrationForm();
            this.Hide();
            regForm.ShowDialog();
            this.Show();
            
            //regForm.Show();
            //this.WindowState = FormWindowState.Minimized;



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

     
        public class LoginFormData
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }

        
        private void signInSubmit_Click(object sender, EventArgs e)
        {
            AccountDetails accountForm = new AccountDetails();
            string name, password;
            name = usernameInput.Text;
            password = passwordInput.Text;
            con.Open();
            List<LoginFormData> registrations = new List<LoginFormData>();
            string query = "SELECT * FROM regDetails;";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LoginFormData loginForm = new LoginFormData();
                loginForm.Name = reader.GetString(0);
                loginForm.Password = reader.GetString(1);
                registrations.Add(loginForm);
                if (name == loginForm.Name)
                {
                    if (password== loginForm.Password)
                    {
                        MessageBox.Show("Congrats you entered the correct info");
                        accountForm.Show();
                        this.WindowState = FormWindowState.Minimized;

                    } else
                    {
                        MessageBox.Show("Wrong Info");
                    }
                    
                } 

                
            }
            reader.Close();
            con.Close();
        }
    }
}
