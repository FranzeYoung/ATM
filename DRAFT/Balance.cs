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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True");

        private void balance1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT Balance FROM Account WHERE AccountNumber = '" + accountnumber.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void return1_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
