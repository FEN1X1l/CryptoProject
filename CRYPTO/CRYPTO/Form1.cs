using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CRYPTO
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(35, 38, 54);
            sidebar.BackColor = Color.FromArgb(29, 30, 51);
            VERText.ForeColor = Color.FromArgb(43, 55, 121);
            Market.ForeColor = Color.FromArgb(43, 55, 121);
            VERText.Text = "build : alpha 1";
            CloseButton.Click += CloseButton_Click;
            More.Click += More_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool sidebarExpand = true;
        
        private void More_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 233)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void Setingsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetingsForm setingsForm = new SetingsForm();
            setingsForm.Show();
        }
    }
}