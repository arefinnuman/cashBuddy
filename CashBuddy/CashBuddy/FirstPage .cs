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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            signIn sp = new signIn();
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup sn = new Signup();
            sn.Show();
        }
    }
}
