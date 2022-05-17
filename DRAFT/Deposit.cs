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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }    

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True");
      
        private void accounttransaction()
        {
            try
            {
                string transaction = "Deposit";

                con.Open();
                string query = "SELECT Balance FROM Account WHERE AccountNumber = '" + accountnumber.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int balance = Convert.ToInt32(dt.Rows[0][0].ToString());

                string query1 = "INSERT INTO AccountTransaction VALUES('" + accountnumber.Text + "','" + DateTime.Now.ToString() + "','" + transaction + "','" + textBox1.Text + "','" + balance + "')";
                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void deposit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                MessageBox.Show("Please enter the amount to deposit");
            }
            else
            {
                try
                {
                    int oldbalance;
                    int newbalance;
                    int depositamount = Convert.ToInt32(textBox1.Text);

                    con.Open();
                    string query = "SELECT Balance FROM Account WHERE AccountNumber = '" + accountnumber.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());

                    newbalance = oldbalance + depositamount;

                    string query1 = "UPDATE Account SET Balance = " + newbalance + " WHERE AccountNumber = '" + accountnumber.Text + "'";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    accounttransaction();

                    MessageBox.Show("The transaction was processed successfully");

                    MainMenu mainmenu = new MainMenu();
                    mainmenu.Show();
                    this.Hide();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }   
            }      
        }


        private void return1_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
