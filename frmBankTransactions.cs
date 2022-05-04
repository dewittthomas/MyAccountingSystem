using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccountingSystem4
{
    public partial class frmBankTransactions : Form     
    {
        //public Form frmBankTransactions = new Form frm();
       
            //InitializeComponent();
            //public Form frmBankTransactions = new frmTransactions();
        //public string ConnectionString = ConfigurationManager.ConnectionStrings["Company"].ConnectionString;
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f2 = new frmMain(); //this is the change, code for redirect  
            f2.Show();

        }
    }
}
