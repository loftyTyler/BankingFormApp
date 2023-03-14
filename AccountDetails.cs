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
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }
        
        private void welcomeOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBalanceForm checkBalance = new CheckBalanceForm();
            checkBalance.ShowDialog();
        }
        
        private void AccountDetails_Load(object sender, EventArgs e)
        {

            string message = LoginForm.name;
            welcomeOutput.Text = message;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawFunds withdrawFunds = new WithdrawFunds();
            withdrawFunds.ShowDialog();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositFunds depositFunds = new DepositFunds();
            depositFunds.ShowDialog();
        }
    }
}
