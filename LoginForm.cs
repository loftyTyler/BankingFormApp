using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        //This code will create the connection the SQL database
        //SQl for laptop
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\telof\source\repos\loftyTyler\BankingFormApp\regDetailsDB.mdf;Integrated Security=True;Connect Timeout=30");
        //Sql for Desktop
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\telof\Documents\regDetailsDB.mdf;Integrated Security = True; Connect Timeout = 30");
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
            using(Entity db = new Entity())
            {
                foreach (var prod in db.databaseTestings)
                {
                    MessageBox.Show($"{prod.name}  {prod.password}  {prod.fullName}  {prod.accountBalance}");
                }
            }
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
        public string password;
        
        
        private void signInSubmit_Click(object sender, EventArgs e)
        {
            //This code will create an instance of AccountDetails so it can show the AccountDetails Form
            AccountDetails accountForm = new AccountDetails();
            //Giving name and password the user inputed values
            name = usernameInput.Text;
            password = passwordInput.Text;
            //Establishment of Connection with SQL database
            con.Open();
            //Creating a List to itterate through with each person in the database
            List<LoginFormData> registrations = new List<LoginFormData>();
            //This is defining the SQL query as a string.  The query is selecting all columns by using '*' from the database
            string query = "SELECT * FROM regDetails2;";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            //While Loop to itertate through each person in the database then put it in the List of LoginFormData
            while (reader.Read())
            {
                LoginFormData loginForm = new LoginFormData();
                loginForm.Name = reader.GetString(0);
                loginForm.Password = reader.GetString(1);
                loginForm.FullName = reader.GetString(2);
                loginForm.AccountBalance = reader.GetDecimal(3);

                registrations.Add(loginForm);
                //If statements to check if account details in database match up with the user input to login
                if (name == loginForm.Name)
                {
                    if (password== loginForm.Password)
                    {
                        MessageBox.Show("Login Successful!");

                        MessageBox.Show(loginForm.FullName + loginForm.AccountBalance);
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
