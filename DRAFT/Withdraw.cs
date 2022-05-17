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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True");

        private void accounttransaction()
        {
            try
            {
                string transaction = "Withdraw";

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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void withdraw1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                MessageBox.Show("Please enter the amount to withdraw");
            }
            else
            {
                try
                {
                    int oldbalance;
                    int newbalance;
                    int withdrawamount = Convert.ToInt32(textBox1.Text);

                    con.Open();
                    string query = "SELECT Balance FROM Account WHERE AccountNumber = '" + accountnumber.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());

                    if (oldbalance > withdrawamount)
                    {
                        newbalance = oldbalance - withdrawamount;

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
                    else
                    {
                        MessageBox.Show("Insufficient balance for the amount requested. Please try again.");
                    }
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
