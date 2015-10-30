using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void makeResultVisible()
        {
            lResult.Visible = true;
            lPayment.Visible = true;
            tBPayment.Visible = true;
        }
        private void makeResultInvisible()
        {
            lResult.Visible = false;
            lPayment.Visible = false;
            tBPayment.Visible = false;
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // calculate the monthly payment
            double price = 0, interest = 0, duration = 0, downPayment = 0, tempNum;

            double.TryParse(tBPrice.Text, out price);
            double.TryParse(tBDuration.Text, out duration);
            duration = duration * 12;
            double.TryParse(tBInterest.Text, out interest);
            interest = interest / 12;
            double.TryParse(tBDown.Text, out downPayment);

            tempNum = interest * (price - downPayment) / (1 - Math.Pow(1 + interest, -duration));
            // save the payment amount to the Text property of tBPayment
            tBPayment.Text = tempNum.ToString("c");

            // we have to make the controls visible
            makeResultVisible();
        }
        private void tBPrice_TextChanged(object sender, EventArgs e)
        {
            makeResultInvisible();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            // calculate the monthly payment
            double price = 0, interest = 0, duration = 0, downPayment = 0, tempNum;

            double.TryParse(tBPrice.Text, out price);
            double.TryParse(tBDuration.Text, out duration);
            duration = duration * 12;
            double.TryParse(tBInterest.Text, out interest);
            interest = interest / 12;
            double.TryParse(tBDown.Text, out downPayment);

            tempNum = interest * (price - downPayment) / (1 - Math.Pow(1 + interest, -duration));
            // save the payment amount to the Message Text Box
            MessageBox.Show(tempNum.ToString("c"), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            tBPayment.Text = tempNum.ToString("c");
            // we have ot make the controls visible
            makeResultVisible();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Vegeta\n A C# The How-Much-You-Are-In-Debt Program", "About This Program");
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: It's over 9000!!!\n", "Program Version");
        }
    }
}
