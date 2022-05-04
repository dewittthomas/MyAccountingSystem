using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAccountingSystem4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

        private void frmCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnBankAcct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBankAccount f2 = new frmBankAccount(); //this is the change, code for redirect  
            f2.Show();
        }

        private void btnBankTrans_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBankTransactions f2 = new frmBankTransactions(); //this is the change, code for redirect  
            f2.Show();

        }
    }
}

