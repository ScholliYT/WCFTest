using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WCFServer.TestServiceClient client = new WCFServer.TestServiceClient();

            double answer = client.plus(Double.Parse(txbWert1.Text), Double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WCFServer.TestServiceClient client = new WCFServer.TestServiceClient();

            double answer = client.minus(Double.Parse(txbWert1.Text), Double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            WCFServer.TestServiceClient client = new WCFServer.TestServiceClient();

            double answer = client.mal(Double.Parse(txbWert1.Text), Double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            WCFServer.TestServiceClient client = new WCFServer.TestServiceClient();

            double answer = client.geteilt(Double.Parse(txbWert1.Text), Double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

    }
}
