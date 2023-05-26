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

    public partial class mobileRecharge : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public mobileRecharge()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "select *from admiin where password =@pass";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@pass", textBox4.Text);

                con1.Open();
                SqlDataReader sda = cmd1.ExecuteReader();

                if (sda.HasRows == true)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into customer_history values ('','',@transaction)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@transaction", textBox3.Text);


                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Bill paid successfully...");
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
