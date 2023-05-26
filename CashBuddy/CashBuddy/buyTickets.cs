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
    public partial class buyTickets : Form
    {
        public buyTickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie m = new Movie();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus b = new Bus();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            airTickets a = new airTickets();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Launch l = new Launch();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train t = new Train();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }
    }
}
