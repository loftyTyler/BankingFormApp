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
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankingFormApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        //SQl for Laptop
        // SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\telof\source\repos\loftyTyler\BankingFormApp\regDetailsDB.mdf;Integrated Security=True;Connect Timeout=30");
        //SQL for desktop
        //SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=databaseTesting;Integrated Security=True");



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerNewAccountButton_Click(object sender, EventArgs e)
        {
            /*This was the old way to do it
            string name, password, confirmPassword, fullName, accountBalance;
            //double accountBalance;
            name = regUsernameInput.Text;
            password = passwordInput.Text;
            confirmPassword = passwordConfirmInput.Text;
            fullName = fullNameInput.Text;
            accountBalance = moneyDepositInput.Text;
            //accountBalance = Double.Parse(stringBalance);
            LoginForm loginForm = new LoginForm();
            if (confirmPassword == password)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into databaseTesting values('" + name + "','" + password + "','" + fullName + "','" + accountBalance +"');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Name:" + name + "\nPassword" + password);
                MessageBox.Show("Record INSERTED successfully...");
                this.Close();
            } else
            {
                MessageBox.Show("Passwords do not match, try again.");
            }*/

            //New code to write into database table
            string user = regUsernameInput.Text;
            string confirmPassword = passwordConfirmInput.Text;
            string password = passwordInput.Text;
            string fullUser = fullNameInput.Text;
            string accountBalanceString = moneyDepositInput.Text;
            // Next step is to do variable != null then only allow the bottom code to initiate if all are not null
            databaseTesting database = new databaseTesting();
            databaseTestingEntities data = new databaseTestingEntities();
            var nameRow = data.databaseTestings.FirstOrDefault(a => a.name == regUsernameInput.Text);
                         
            if (nameRow != null)
            {
                MessageBox.Show("Username is already taken.");
            }
            else
            {
                if (password == confirmPassword)
                {
                    database.name = regUsernameInput.Text;
                    database.password = passwordInput.Text;
                    database.fullName = fullNameInput.Text;

                    database.accountBalance = Decimal.Parse(accountBalanceString);
                    data.databaseTestings.Add(database);
                    data.SaveChanges();
                    MessageBox.Show("Record INSERTED successfully..");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }                                                                              
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
