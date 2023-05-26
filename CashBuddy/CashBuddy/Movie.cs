using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CashBuddy
{
    public partial class Movie : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Movie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            buyTickets b1 = new buyTickets();
            b1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ticketPrice = 350;
            int totalPrice = Convert.ToInt32((numericUpDown1.Value)) * ticketPrice;


            if (textBox5.Text != "")
            {
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "select *from admiin where password =@pass";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@pass", textBox5.Text);

                con1.Open();
                SqlDataReader sda = cmd1.ExecuteReader();

                if (sda.HasRows == true)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into customer_history values ('',@ticket,@transaction)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ticket", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@transaction", totalPrice);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Your tickets are ready...");
                        MessageBox.Show("Total : " + totalPrice);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide your buddy pin correctly...");
                }
            }
        }
    }
}
