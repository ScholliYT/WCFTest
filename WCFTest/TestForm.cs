using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFTest.ServiceReference1;

namespace WCFTest
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.TestServiceClient client = new ServiceReference1.TestServiceClient();

            double answer;
            answer = client.plus(txbWert1.Text, txbWert2.Text);
            lblOutput.Text = answer;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ServiceReference1.TestServiceClient client = new ServiceReference1.TestServiceClient();

            double answer;
            answer = client.minus(txbWert1.Text, txbWert2.Text);
            lblOutput.Text = answer;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ServiceReference1.TestServiceClient client = new ServiceReference1.TestServiceClient();

            double answer;
            answer = client.mal(txbWert1.Text, txbWert2.Text);
            lblOutput.Text = answer;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            ServiceReference1.TestServiceClient client = new ServiceReference1.TestServiceClient();

            double answer;
            answer = client.geteilt(txbWert1.Text, txbWert2.Text);
            lblOutput.Text = answer;
        }
    }
}
