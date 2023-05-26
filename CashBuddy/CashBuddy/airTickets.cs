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
    public partial class airTickets : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public airTickets()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            buyTickets bu = new buyTickets();
            bu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    int ticketPrice = 40000;
                    int totalPrice1 = Convert.ToInt32((numericUpDown1.Value)) * ticketPrice;
                    int totalPrice2 = Convert.ToInt32((numericUpDown1.Value)) * ticketPrice + (Convert.ToInt32((numericUpDown1.Value)) * ticketPrice);

                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into customer_history values ('',@ticket,@transaction)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ticket", comboBox1.Text);


                    if (radioButton1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@transaction", totalPrice1);
                    }
                    if (radioButton2.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@transaction", totalPrice2);

                    }

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        if (radioButton1.Checked == true)
                        {
                            int totalPrice = Convert.ToInt32((numericUpDown1.Value)) * ticketPrice;
                            MessageBox.Show("Your tickets are ready...");
                            MessageBox.Show("Total : " + totalPrice);
                        }
                        else if (radioButton2.Checked == true)
                        {
                            int totalPrice = Convert.ToInt32((numericUpDown1.Value)) * ticketPrice + (Convert.ToInt32((numericUpDown1.Value)) * ticketPrice);
                            MessageBox.Show("Your tickets are ready...");
                            MessageBox.Show("Total : " + totalPrice);
                        }
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
