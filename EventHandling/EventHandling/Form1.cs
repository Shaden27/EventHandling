using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandling
{
    public partial class Form1 : Form
    {
        Bank bank;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dep = Convert.ToDouble(textBox1.Text);
            bank.deposit(dep);
            label1.Text = Convert.ToString(bank.netBal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bank = new Bank();
            label1.Text = Convert.ToString(bank.netBal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double wit = Convert.ToDouble(textBox2.Text);
            bank.withdraw(wit);
            label1.Text = Convert.ToString(bank.netBal);
        }
    }
}
