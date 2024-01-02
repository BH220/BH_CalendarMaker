namespace BH_CalendarMaker.Anniversary
{
    partial class frmAnniversaryList
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
            this.bhGrid = new BH_Core.Controls.BhGrid.BhGrid(this.components);
            this.bhSearchBox1 = new BH_Core.Controls.Component.BhSearchBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbAll = new BH_Core.Controls.Component.BhRadioButton();
            this.rbHollyDay = new BH_Core.Controls.Component.BhRadioButton();
            this.rbBirthDay = new BH_Core.Controls.Component.BhRadioButton();
            this.rbSpecialDay = new BH_Core.Controls.Component.BhRadioButton();
            this.rbTask = new BH_Core.Controls.Component.BhRadioButton();
            this.rbMoon = new BH_Core.Controls.Component.BhRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bhGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bhGrid
            // 
            this.bhGrid.AllowPopupMenu = true;
            this.bhGrid.AllowUserToAddRows = false;
            this.bhGrid.AllowUserToDeleteRows = false;
            this.bhGrid.AllowUserToResizeRows = false;
            this.bhGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bhGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bhGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhGrid.Location = new System.Drawing.Point(0, 52);
            this.bhGrid.MultiSelect = false;
            this.bhGrid.Name = "bhGrid";
            this.bhGrid.RowTemplate.Height = 23;
            this.bhGrid.SearchAfterLLastRowFocus = true;
            this.bhGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bhGrid.Size = new System.Drawing.Size(964, 387);
            this.bhGrid.TabIndex = 2;
            // 
            // bhSearchBox1
            // 
            this.bhSearchBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhSearchBox1.Location = new System.Drawing.Point(0, 25);
            this.bhSearchBox1.MaximumSize = new System.Drawing.Size(2000, 27);
            this.bhSearchBox1.MinimumSize = new System.Drawing.Size(550, 27);
            this.bhSearchBox1.Name = "bhSearchBox1";
            this.bhSearchBox1.Size = new System.Drawing.Size(964, 27);
            this.bhSearchBox1.TabIndex = 3;
            this.bhSearchBox1.VisibleDateSearch = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbAll);
            this.flowLayoutPanel1.Controls.Add(this.rbHollyDay);
            this.flowLayoutPanel1.Controls.Add(this.rbBirthDay);
            this.flowLayoutPanel1.Controls.Add(this.rbSpecialDay);
            this.flowLayoutPanel1.Controls.Add(this.rbTask);
            this.flowLayoutPanel1.Controls.Add(this.rbMoon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 23);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tbAll
            // 
            this.tbAll.AutoSize = true;
            this.tbAll.BhGroupName = null;
            this.tbAll.Checked = true;
            this.tbAll.EditValue = true;
            this.tbAll.Location = new System.Drawing.Point(3, 3);
            this.tbAll.Name = "tbAll";
            this.tbAll.RequireValueError = null;
            this.tbAll.Size = new System.Drawing.Size(47, 16);
            this.tbAll.TabIndex = 0;
            this.tbAll.TabStop = true;
            this.tbAll.Text = "전체";
            this.tbAll.UseVisualStyleBackColor = true;
            this.tbAll.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHollyDay
            // 
            this.rbHollyDay.AutoSize = true;
            this.rbHollyDay.BhGroupName = null;
            this.rbHollyDay.EditValue = false;
            this.rbHollyDay.Location = new System.Drawing.Point(56, 3);
            this.rbHollyDay.Name = "rbHollyDay";
            this.rbHollyDay.RequireValueError = null;
            this.rbHollyDay.Size = new System.Drawing.Size(59, 16);
            this.rbHollyDay.TabIndex = 2;
            this.rbHollyDay.Text = "공휴일";
            this.rbHollyDay.UseVisualStyleBackColor = true;
            this.rbHollyDay.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBirthDay
            // 
            this.rbBirthDay.AutoSize = true;
            this.rbBirthDay.BhGroupName = null;
            this.rbBirthDay.EditValue = false;
            this.rbBirthDay.Location = new System.Drawing.Point(121, 3);
            this.rbBirthDay.Name = "rbBirthDay";
            this.rbBirthDay.RequireValueError = null;
            this.rbBirthDay.Size = new System.Drawing.Size(47, 16);
            this.rbBirthDay.TabIndex = 3;
            this.rbBirthDay.Text = "생일";
            this.rbBirthDay.UseVisualStyleBackColor = true;
            this.rbBirthDay.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSpecialDay
            // 
            this.rbSpecialDay.AutoSize = true;
            this.rbSpecialDay.BhGroupName = null;
            this.rbSpecialDay.EditValue = false;
            this.rbSpecialDay.Location = new System.Drawing.Point(174, 3);
            this.rbSpecialDay.Name = "rbSpecialDay";
            this.rbSpecialDay.RequireValueError = null;
            this.rbSpecialDay.Size = new System.Drawing.Size(59, 16);
            this.rbSpecialDay.TabIndex = 4;
            this.rbSpecialDay.Text = "기념일";
            this.rbSpecialDay.UseVisualStyleBackColor = true;
            this.rbSpecialDay.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbTask
            // 
            this.rbTask.AutoSize = true;
            this.rbTask.BhGroupName = null;
            this.rbTask.EditValue = false;
            this.rbTask.Location = new System.Drawing.Point(239, 3);
            this.rbTask.Name = "rbTask";
            this.rbTask.RequireValueError = null;
            this.rbTask.Size = new System.Drawing.Size(47, 16);
            this.rbTask.TabIndex = 5;
            this.rbTask.Text = "일정";
            this.rbTask.UseVisualStyleBackColor = true;
            this.rbTask.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMoon
            // 
            this.rbMoon.AutoSize = true;
            this.rbMoon.BhGroupName = null;
            this.rbMoon.EditValue = false;
            this.rbMoon.Location = new System.Drawing.Point(292, 3);
            this.rbMoon.Name = "rbMoon";
            this.rbMoon.RequireValueError = null;
            this.rbMoon.Size = new System.Drawing.Size(47, 16);
            this.rbMoon.TabIndex = 6;
            this.rbMoon.Text = "절기";
            this.rbMoon.UseVisualStyleBackColor = true;
            this.rbMoon.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // frmAnniversaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bhGrid);
            this.Controls.Add(this.bhSearchBox1);
            this.Name = "frmAnniversaryList";
            this.Text = "기념일 관리";
            this.Title = "기념일 관리";
            this.Controls.SetChildIndex(this.bhSearchBox1, 0);
            this.Controls.SetChildIndex(this.bhGrid, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bhGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BH_Core.Controls.BhGrid.BhGrid bhGrid;
        private BH_Core.Controls.Component.BhSearchBox bhSearchBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private BH_Core.Controls.Component.BhRadioButton tbAll;
        private BH_Core.Controls.Component.BhRadioButton rbHollyDay;
        private BH_Core.Controls.Component.BhRadioButton rbBirthDay;
        private BH_Core.Controls.Component.BhRadioButton rbSpecialDay;
        private BH_Core.Controls.Component.BhRadioButton rbTask;
        private BH_Core.Controls.Component.BhRadioButton rbMoon;
    }
}