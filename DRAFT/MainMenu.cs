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

namespace DRAFT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True"); 

        private void balanceinquiry_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }      

        private void deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();                     
        }

        private void history_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionhistory = new TransactionHistory();
            transactionhistory.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
