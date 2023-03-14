using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingFormApp
{
    public partial class DepositFunds : Form
    {
        public DepositFunds()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void depositFundsButton_Click(object sender, EventArgs e)
        {
            string username = LoginForm.name;
            string password = LoginForm.password;
            string depositAmt = depositFundsInput.Text;
            decimal depositAmtDbl = Decimal.Parse(depositAmt);


            using (databaseTestingEntities db = new databaseTestingEntities())
            {
                //databaseTesting database = new databaseTesting();
                var user = db.databaseTestings.FirstOrDefault(u => u.name == username && u.password == password);
                if (user != null)
                {
                    user.accountBalance += depositAmtDbl;
                    db.SaveChanges();
                    MessageBox.Show(user.accountBalance.ToString("C", CultureInfo.CurrentCulture));
                }
            }
        }
    }
}
