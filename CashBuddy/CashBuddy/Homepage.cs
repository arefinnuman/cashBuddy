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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        public Homepage(string value)
        {
            InitializeComponent();
            label3.Text = value;
        }
        private void bb_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWallet aw = new AddWallet();
            aw.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            payMoney pm = new payMoney();
            pm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            transferMoney tm = new transferMoney();
            tm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            convertingCurrency cc = new convertingCurrency();
            cc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mobileRecharge mr = new mobileRecharge();
            mr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            payBill bp = new payBill();
            bp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            buyTickets bt = new buyTickets();
            bt.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Savings s = new Savings();
            s.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHistory ch = new CustomerHistory();
            ch.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpLine hl = new HelpLine();
            hl.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            signIn si = new signIn();
            si.Show();
        }
    }
}
