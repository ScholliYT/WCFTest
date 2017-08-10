using System;
using System.Windows.Forms;
using ClientTestForm.WCFServer;
using System.Runtime.InteropServices;

namespace ClientTestForm
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams; cp.Style |= WS_MINIMIZEBOX; cp.ClassStyle |= CS_DBLCLKS; return cp;
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        public void mouseMove(MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove(e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}