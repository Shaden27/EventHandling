using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Bank
    {
        public double netBal;
        public Bank()
        {
            netBal = 5000;
        }
        public Bank(double b)
        {
            netBal = b;
        }
        public void deposit(double dep)
        {
            double test = netBal + dep;
            if (netBal > 100000)
            {
                netBal = netBal + 0.7 * dep;
                System.Windows.Forms.MessageBox.Show("Tax Cut");
            }
            else if (test > 100000)
            {
                test = test - 100000;
                test = 0.3 * test;
                netBal = netBal + dep - test;
                System.Windows.Forms.MessageBox.Show("Tax Cut");
            }
            else
            {
                netBal = netBal + dep;
            }
        }
        public void withdraw(double wit)
        {
            double test = netBal - wit;
            if (test < 5000)
            {
                System.Windows.Forms.MessageBox.Show("Cannot Withdraw Minimun Balance should ve 5000");
            }
            else
            {
                netBal = netBal - wit;
            }
        }
    }
}
