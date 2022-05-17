using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRAFT
{
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        private void accountTransactionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountTransactionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transactionDataSet);

        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionDataSet.AccountTransaction' table. You can move, or remove it, as needed.
            this.accountTransactionTableAdapter.Fill(this.transactionDataSet.AccountTransaction);

        }

        private void return1_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
