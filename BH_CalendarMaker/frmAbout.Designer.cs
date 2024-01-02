namespace BH_CalendarMaker
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.llbDevExpress = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // llbDevExpress
            // 
            this.llbDevExpress.BackColor = System.Drawing.Color.Transparent;
            this.llbDevExpress.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.llbDevExpress.Location = new System.Drawing.Point(0, 0);
            this.llbDevExpress.Name = "llbDevExpress";
            this.llbDevExpress.Size = new System.Drawing.Size(399, 18);
            this.llbDevExpress.TabIndex = 1;
            this.llbDevExpress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llbDevExpress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDevExpress_LinkClicked);
            this.llbDevExpress.MouseEnter += new System.EventHandler(this.llbDevExpress_MouseEnter);
            this.llbDevExpress.MouseLeave += new System.EventHandler(this.llbDevExpress_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(290, 206);
            this.ControlBox = false;
            this.Controls.Add(this.llbDevExpress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = BH_CalendarMaker.Properties.Resources.Main;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Opacity = 0D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About TuningShopManager";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAbout_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbout_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmAbout_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAbout_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAbout_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAbout_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

    }
}

