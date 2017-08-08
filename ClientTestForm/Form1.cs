using System;
using System.Windows.Forms;
using ClientTestForm.WCFServer;

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
            var client = new TestServiceClient();

            var answer = client.plus(double.Parse(txbWert1.Text), double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var client = new TestServiceClient();

            var answer = client.minus(double.Parse(txbWert1.Text), double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var client = new TestServiceClient();

            var answer = client.mal(double.Parse(txbWert1.Text), double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            var client = new TestServiceClient();

            var answer = client.geteilt(double.Parse(txbWert1.Text), double.Parse(txbWert2.Text));
            lblOutput.Text = "Output: " + answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}