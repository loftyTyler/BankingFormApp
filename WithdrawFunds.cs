using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankingFormApp
{
    public partial class WithdrawFunds : Form
    {
        public WithdrawFunds()
        {
            InitializeComponent();
        }

        private void WithdrawFunds_Load(object sender, EventArgs e)
        {
            

        }

        private void withdrawFundsButton_Click(object sender, EventArgs e)
        {
            string username = LoginForm.name;
            string password = LoginForm.password;
            string withdrawAmt = withdrawFundsInput.Text;
            decimal withdrawAmtDbl = Decimal.Parse(withdrawAmt);
            
                      
            using (databaseTestingEntities db = new databaseTestingEntities())
            {
                //databaseTesting database = new databaseTesting();
                var user = db.databaseTestings.FirstOrDefault(u => u.name == username && u.password == password);
                if (user != null)
                {     
                    if (withdrawAmtDbl < user.accountBalance)
                    {
                        user.accountBalance -= withdrawAmtDbl;
                        db.SaveChanges();
                        MessageBox.Show(user.accountBalance.ToString("C", CultureInfo.CurrentCulture));
                    } else
                    {
                        MessageBox.Show("Insufficient Funds");
                    }
                    
                }
            }
        }
    }
}
