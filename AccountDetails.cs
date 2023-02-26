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



        private void UpdateSelectedUserLabel(string username)
        {
            welcomeOutput.Text = username;
        }
    }
}
