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
    public partial class convertingCurrency : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public convertingCurrency ()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taka = Convert.ToInt32(textBox4.Text);
            int dollar = taka * 86;
            int euro = taka * 97;
            int pound = taka * 114;
            int rupee = taka * 2;
            int riyal = taka * 23;
            int dinar = taka * 283;

            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter your buddy pin...");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into customer_history values ('','',@transaction)";
                SqlCommand cmd = new SqlCommand(query, con);

                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@transaction", dollar);
                }
                if (radioButton4.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@transaction", euro);
                }
                if (radioButton5.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@transaction", pound);
                }
                if (radioButton6.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@transaction", rupee);
                }
                if (radioButton7.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@transaction", riyal);
                }
                if (radioButton8.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@transaction", dinar);
                }

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Converted Amount : " + dollar + " dollar...");
                        textBox4.Clear();
                    }
                    if (radioButton4.Checked == true)
                    {
                        MessageBox.Show("Converted Amount : " + euro + " euro...");
                        textBox4.Clear();
                    }
                    if (radioButton5.Checked == true)
                    {
                        MessageBox.Show("Converted Amount : " + pound + " pound...");
                        textBox4.Clear();
                    }
                    if (radioButton6.Checked == true)
                    {
                        MessageBox.Show("Converted Amount : " + rupee + " rupee...");
                        textBox4.Clear();
                    }
                    if (radioButton7.Checked == true)
                    {
                        MessageBox.Show("Converted Amount " + riyal + " riyal...");
                        textBox4.Clear();
                    }
                    if (radioButton8.Checked == true)
                    {
                        MessageBox.Show("Converted Amount " + dinar + " dinar...");
                        textBox4.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error...");
                }
            }
        }
    }
}
