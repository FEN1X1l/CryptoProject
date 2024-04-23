namespace CRYPTO
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebar = new System.Windows.Forms.Panel();
            this.Setingsbtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Market = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.More = new System.Windows.Forms.PictureBox();
            this.VERText = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setingsbtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.More)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.CadetBlue;
            this.sidebar.Controls.Add(this.Setingsbtn);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.More);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(233, 577);
            this.sidebar.TabIndex = 0;
            // 
            // Setingsbtn
            // 
            this.Setingsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Setingsbtn.Image")));
            this.Setingsbtn.Location = new System.Drawing.Point(3, 534);
            this.Setingsbtn.Name = "Setingsbtn";
            this.Setingsbtn.Size = new System.Drawing.Size(37, 40);
            this.Setingsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Setingsbtn.TabIndex = 3;
            this.Setingsbtn.TabStop = false;
            this.Setingsbtn.Click += new System.EventHandler(this.Setingsbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Market);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 62);
            this.panel1.TabIndex = 2;
            // 
            // Market
            // 
            this.Market.AutoSize = true;
            this.Market.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Market.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Market.Location = new System.Drawing.Point(79, 22);
            this.Market.Name = "Market";
            this.Market.Size = new System.Drawing.Size(90, 26);
            this.Market.TabIndex = 1;
            this.Market.Text = "MARKET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // More
            // 
            this.More.Image = ((System.Drawing.Image)(resources.GetObject("More.Image")));
            this.More.InitialImage = null;
            this.More.Location = new System.Drawing.Point(0, 0);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(40, 40);
            this.More.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.More.TabIndex = 1;
            this.More.TabStop = false;
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // VERText
            // 
            this.VERText.AutoSize = true;
            this.VERText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VERText.Location = new System.Drawing.Point(869, 562);
            this.VERText.Name = "VERText";
            this.VERText.Size = new System.Drawing.Size(38, 15);
            this.VERText.TabIndex = 2;
            this.VERText.Text = "label1";
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(896, -9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(54, 52);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.VERText);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Setingsbtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.More)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sidebar;
        private PictureBox CloseButton;
        private PictureBox More;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label VERText;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label Market;
        private PictureBox Setingsbtn;
    }
}