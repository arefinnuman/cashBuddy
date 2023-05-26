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
    public partial class AddBkash : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AddBkash()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWallet aw = new AddWallet();
            aw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "select *from admiin where password =@pass";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@pass", textBox2.Text);

                con1.Open();
                SqlDataReader sda = cmd1.ExecuteReader();

                if (sda.HasRows == true)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into customer_history values (@account,'','')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@account", label4.Text);


                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Account added successfully...");
                    }
                    else
                    {
                        MessageBox.Show("Failed...");
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
