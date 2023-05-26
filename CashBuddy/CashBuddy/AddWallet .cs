using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBuddy
{
    public partial class AddWallet : Form
    {
        public AddWallet()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBkash ab = new AddBkash();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNogod an = new AddNogod();
            an.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRocket ar = new AddRocket();
            ar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            addBankAccount aba = new addBankAccount();
            aba.Show();
        }
    }
}
