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
    public partial class frmBankAccount : Form
    {
        public frmBankAccount()
        {
            InitializeComponent();
        }

        public SqlConnection  SqlConn;

        public string Password = string.Empty;
        public string ConnectString = ConfigurationManager.ConnectionStrings["Company"].ConnectionString;
        SqlConnection conn = new SqlConnection();
        //ConnectionString = "Data Source=127.0.0.1.;" +
        //                "Initial Catalog=Filter;" +
        //                "Integrated Security=SSPI;";

        //conn.Open();        //SqlConnection con = new SqlConnection(connectionString);

        private void Clear_Form()
        {
            txtAccountNumber.Text = String.Empty;
            txtBalance.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f2 = new frmMain(); //this is the change, code for redirect  
            f2.Show();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                using (SqlCommand command = new SqlCommand("BankAccountAdd", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    SqlParameter param = new SqlParameter();
                    command.Parameters.AddWithValue("BankAccount", txtAccountNumber.Text);
                    command.Parameters.AddWithValue("FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("Balance", txtBalance.Text);
                    //command.Parameters.AddWithValue("Active", chkInactive.Text);


                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    {
        //        using (SqlConnection command = new SqlConnection(ConnectString))
        //        {
        //            //using (SqlCommand command = new SqlCommand("AddressAdd", "Data Source = 127.0.0.1; Initial Catalog = Company; Integrated Security = SSPI;))
        //            //conn.ConnectionString
        //            //command.ConnectionString = ConnectString;   // = CommandType.StoredProcedure;
        //            //command.ConnectString(); Parameters.Clear();
        //            SqlParameter param = new SqlParameter();
        //            txtAccountNumber.Text = String.Empty;
        //            txtBalance.Text = String.Empty;
        //            txtFirstName.Text = String.Empty;
        //            txtLastName.Text = String.Empty;

        //            //command.Parameters.AddWithValue("DepartmentName", txtDepartmentName.Text);
        //            command.Parameters.AddWithValue("AccountNumber", txtAccountNumber.Text);
        //            command.Parameters.AddWithValue("FirstName", txtFirstName.Text);
        //            command.Parameters.AddWithValue("LastName", txtLastName.Text);
        //            command.Parameters.AddWithValue("Balance", Convert.ToInt32(txtBalance.Text));

        //            conn.Open();
        //            command.ExecuteNonQuery();
        //            conn.Close();
        //        }
        //    }


        //}

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
