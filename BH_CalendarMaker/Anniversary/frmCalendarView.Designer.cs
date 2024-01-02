namespace BH_CalendarMaker.Anniversary
{
    partial class frmCalendarView
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
            this.bhPanel1 = new BH_Core.Controls.Component.BhPanel();
            this.btnNext = new BH_Core.Controls.Component.BhButton();
            this.btnPre = new BH_Core.Controls.Component.BhButton();
            this.bhButton1 = new BH_Core.Controls.Component.BhButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ctlCalendarView1 = new BH_CalendarMaker.Anniversary.ctlCalendarView();
            this.btnRefresh = new BH_Core.Controls.Component.BhButton();
            this.bhPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bhPanel1
            // 
            this.bhPanel1.BorderColor = System.Drawing.SystemColors.Control;
            this.bhPanel1.Controls.Add(this.btnRefresh);
            this.bhPanel1.Controls.Add(this.btnNext);
            this.bhPanel1.Controls.Add(this.btnPre);
            this.bhPanel1.Controls.Add(this.bhButton1);
            this.bhPanel1.Controls.Add(this.dateTimePicker1);
            this.bhPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhPanel1.Location = new System.Drawing.Point(5, 30);
            this.bhPanel1.Name = "bhPanel1";
            this.bhPanel1.Size = new System.Drawing.Size(954, 27);
            this.bhPanel1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.BhGroupName = null;
            this.btnNext.EditValue = null;
            this.btnNext.Image = null;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(193, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.RequireValueError = null;
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "다음달";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.BhGroupName = null;
            this.btnPre.EditValue = null;
            this.btnPre.Image = null;
            this.btnPre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPre.Location = new System.Drawing.Point(3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.RequireValueError = null;
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "이전달";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // bhButton1
            // 
            this.bhButton1.BhGroupName = null;
            this.bhButton1.EditValue = null;
            this.bhButton1.Image = null;
            this.bhButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bhButton1.Location = new System.Drawing.Point(3, 2);
            this.bhButton1.Name = "bhButton1";
            this.bhButton1.RequireValueError = null;
            this.bhButton1.Size = new System.Drawing.Size(75, 23);
            this.bhButton1.TabIndex = 4;
            this.bhButton1.Text = "bhButton1";
            this.bhButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy년 MM월";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ctlCalendarView1
            // 
            this.ctlCalendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlCalendarView1.Location = new System.Drawing.Point(5, 57);
            this.ctlCalendarView1.Margin = new System.Windows.Forms.Padding(5);
            this.ctlCalendarView1.Name = "ctlCalendarView1";
            this.ctlCalendarView1.Size = new System.Drawing.Size(954, 377);
            this.ctlCalendarView1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BhGroupName = null;
            this.btnRefresh.EditValue = null;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(826, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RequireValueError = null;
            this.btnRefresh.Size = new System.Drawing.Size(125, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "공공데이터 재조회";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 461);
            this.Controls.Add(this.ctlCalendarView1);
            this.Controls.Add(this.bhPanel1);
            this.Name = "frmCalendarView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "기념일 관리";
            this.Title = "기념일 관리";
            this.Controls.SetChildIndex(this.bhPanel1, 0);
            this.Controls.SetChildIndex(this.ctlCalendarView1, 0);
            this.bhPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BH_Core.Controls.Component.BhPanel bhPanel1;
        private ctlCalendarView ctlCalendarView1;
        private BH_Core.Controls.Component.BhButton btnNext;
        private BH_Core.Controls.Component.BhButton btnPre;
        private BH_Core.Controls.Component.BhButton bhButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private BH_Core.Controls.Component.BhButton btnRefresh;
    }
}