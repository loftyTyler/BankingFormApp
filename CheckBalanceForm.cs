using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankingFormApp
{
    public partial class CheckBalanceForm : Form
    {
        public CheckBalanceForm()
        {
            InitializeComponent();
        }

        private void CheckBalanceForm_Load(object sender, EventArgs e)
        {
            string username = LoginForm.name;
            string password = LoginForm.password;

            //Need to add a balance loader of specific person balance
            
            using (databaseTestingEntities db = new databaseTestingEntities())
            {
                
                var user = db.databaseTestings.FirstOrDefault(u => u.name == username && u.password == password);
                if (user != null)
                {
                    decimal balance = user.accountBalance;
                    balanceOutput.Text = balance.ToString();
                    

                }
            }
        }
    }
}
