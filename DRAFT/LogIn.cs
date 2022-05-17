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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                  
            SqlConnection sqlcon = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True");
            string query = "SELECT * FROM Account WHERE AccountNumber = '" + textBox1.Text + "' AND PIN = '" + textBox2.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MainMenu mainmenu = new MainMenu();
                mainmenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Account Number or PIN. Try again.");
            }
        }
    }
}
