using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CRYPTO
{
    public partial class SetingsForm : Form
    {
        public SetingsForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(35, 38, 54);
            sidebar.BackColor = Color.FromArgb(29, 30, 51);
            VERText.ForeColor = Color.FromArgb(43, 55, 121);
            Market.ForeColor = Color.FromArgb(43, 55, 121);
            VERText.Text = "build : alpha 1";
            CloseButton.Click += CloseButton_Click;
            More.Click += More_Click;
            textBox1.BackColor = Color.FromArgb(43, 55, 121);
            
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool sidebarExpand = true;

        private void More_Click(object sender, EventArgs e)
        {
            sidebarTransition1.Start();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void sidebarTransition_Tick1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTransition1.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 233)
                {
                    sidebarExpand = true;
                    sidebarTransition1.Stop();
                }
            }
        }

        
                
            
        
    }
}
