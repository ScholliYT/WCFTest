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

        private void btnDiv_Click(object sender, EventArgs e)
        {
            WCFServer.TestServiceClient client = new WCFServer.TestServiceClient();

            double answer = client.geteilt(Double.Parse(txbWert1.Text), Double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbWert2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbWert1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
