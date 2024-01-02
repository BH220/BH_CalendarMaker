
namespace BH_CalendarMaker.Anniversary
{
    partial class frmExportExcel
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
            this.bhPanel2 = new BH_Core.Controls.Component.BhPanel();
            this.btnExport = new BH_Core.Controls.Component.BhButton();
            this.txtPath = new BH_Core.Controls.Component.BhTextBox();
            this.btnOpenFile = new BH_Core.Controls.Component.BhButton();
            this.btnSetYear = new BH_Core.Controls.Component.BhButton();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.bhLabel10 = new BH_Core.Controls.Component.BhLabel();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.bhLabel4 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel2 = new BH_Core.Controls.Component.BhLabel();
            this.rgExcelType = new BH_Core.Controls.Component.BhRadioGroup();
            this.bhLabel1 = new BH_Core.Controls.Component.BhLabel();
            this.bhPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bhPanel2
            // 
            this.bhPanel2.BorderColor = System.Drawing.SystemColors.Control;
            this.bhPanel2.Controls.Add(this.btnExport);
            this.bhPanel2.Controls.Add(this.txtPath);
            this.bhPanel2.Controls.Add(this.btnOpenFile);
            this.bhPanel2.Controls.Add(this.btnSetYear);
            this.bhPanel2.Controls.Add(this.dtEnd);
            this.bhPanel2.Controls.Add(this.bhLabel10);
            this.bhPanel2.Controls.Add(this.dtStart);
            this.bhPanel2.Controls.Add(this.bhLabel4);
            this.bhPanel2.Controls.Add(this.bhLabel2);
            this.bhPanel2.Controls.Add(this.rgExcelType);
            this.bhPanel2.Controls.Add(this.bhLabel1);
            this.bhPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bhPanel2.Location = new System.Drawing.Point(0, 0);
            this.bhPanel2.Name = "bhPanel2";
            this.bhPanel2.Size = new System.Drawing.Size(386, 188);
            this.bhPanel2.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.BhGroupName = null;
            this.btnExport.EditValue = null;
            this.btnExport.Image = null;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(299, 153);
            this.btnExport.Name = "btnExport";
            this.btnExport.RequireValueError = null;
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "내보내기";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtPath
            // 
            this.txtPath.BhGroupName = null;
            this.txtPath.EditValue = "";
            this.txtPath.Location = new System.Drawing.Point(147, 104);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.RequireValueError = null;
            this.txtPath.SearchButtonEnable = true;
            this.txtPath.SearchButtonVisible = false;
            this.txtPath.Size = new System.Drawing.Size(228, 21);
            this.txtPath.TabIndex = 15;
            this.txtPath.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPath.WaterMarkText = "";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BhGroupName = null;
            this.btnOpenFile.EditValue = null;
            this.btnOpenFile.Image = global::BH_CalendarMaker.Properties.Resources._003_folder;
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(118, 102);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.RequireValueError = null;
            this.btnOpenFile.Size = new System.Drawing.Size(23, 23);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Text = "    ";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSetYear
            // 
            this.btnSetYear.BhGroupName = null;
            this.btnSetYear.EditValue = null;
            this.btnSetYear.Image = null;
            this.btnSetYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetYear.Location = new System.Drawing.Point(118, 71);
            this.btnSetYear.Name = "btnSetYear";
            this.btnSetYear.RequireValueError = null;
            this.btnSetYear.Size = new System.Drawing.Size(123, 23);
            this.btnSetYear.TabIndex = 13;
            this.btnSetYear.Text = "시작일 기준 연도";
            this.btnSetYear.UseVisualStyleBackColor = true;
            this.btnSetYear.Click += new System.EventHandler(this.btnSetYear_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy년 MM월";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(260, 41);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(88, 21);
            this.dtEnd.TabIndex = 12;
            // 
            // bhLabel10
            // 
            this.bhLabel10.BhGroupName = "";
            this.bhLabel10.EditValue = "~";
            this.bhLabel10.IsRequireValue = false;
            this.bhLabel10.Location = new System.Drawing.Point(212, 40);
            this.bhLabel10.Name = "bhLabel10";
            this.bhLabel10.RequireValueError = "";
            this.bhLabel10.Size = new System.Drawing.Size(42, 23);
            this.bhLabel10.TabIndex = 11;
            this.bhLabel10.Text = "~";
            this.bhLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "yyyy년 MM월";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(118, 41);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(88, 21);
            this.dtStart.TabIndex = 10;
            // 
            // bhLabel4
            // 
            this.bhLabel4.BhGroupName = "";
            this.bhLabel4.EditValue = "내보낼 파일명";
            this.bhLabel4.IsRequireValue = false;
            this.bhLabel4.Location = new System.Drawing.Point(12, 102);
            this.bhLabel4.Name = "bhLabel4";
            this.bhLabel4.RequireValueError = "";
            this.bhLabel4.Size = new System.Drawing.Size(100, 23);
            this.bhLabel4.TabIndex = 4;
            this.bhLabel4.Text = "내보낼 파일명";
            this.bhLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel2
            // 
            this.bhLabel2.BhGroupName = "";
            this.bhLabel2.EditValue = "기간";
            this.bhLabel2.IsRequireValue = false;
            this.bhLabel2.Location = new System.Drawing.Point(12, 40);
            this.bhLabel2.Name = "bhLabel2";
            this.bhLabel2.RequireValueError = "";
            this.bhLabel2.Size = new System.Drawing.Size(100, 23);
            this.bhLabel2.TabIndex = 2;
            this.bhLabel2.Text = "기간";
            this.bhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rgExcelType
            // 
            this.rgExcelType.BackColor = System.Drawing.SystemColors.Window;
            this.rgExcelType.BhGroupName = null;
            this.rgExcelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rgExcelType.EditValue = "-1";
            this.rgExcelType.FormattingEnabled = true;
            this.rgExcelType.ItemHeight = 18;
            this.rgExcelType.Items.AddRange(new object[] {
            "A3 내보내기",
            "A5 내보내기"});
            this.rgExcelType.Location = new System.Drawing.Point(118, 9);
            this.rgExcelType.MultiColumn = true;
            this.rgExcelType.Name = "rgExcelType";
            this.rgExcelType.RequireValueError = null;
            this.rgExcelType.Size = new System.Drawing.Size(257, 22);
            this.rgExcelType.TabIndex = 1;
            // 
            // bhLabel1
            // 
            this.bhLabel1.BhGroupName = "";
            this.bhLabel1.EditValue = "엑셀 형태";
            this.bhLabel1.IsRequireValue = false;
            this.bhLabel1.Location = new System.Drawing.Point(12, 9);
            this.bhLabel1.Name = "bhLabel1";
            this.bhLabel1.RequireValueError = "";
            this.bhLabel1.Size = new System.Drawing.Size(100, 23);
            this.bhLabel1.TabIndex = 0;
            this.bhLabel1.Text = "엑셀 형태";
            this.bhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmExportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 188);
            this.Controls.Add(this.bhPanel2);
            this.Name = "frmExportExcel";
            this.Text = "엑셀 내보내기";
            this.bhPanel2.ResumeLayout(false);
            this.bhPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BH_Core.Controls.Component.BhPanel bhPanel2;
        private BH_Core.Controls.Component.BhLabel bhLabel4;
        private BH_Core.Controls.Component.BhLabel bhLabel2;
        private BH_Core.Controls.Component.BhRadioGroup rgExcelType;
        private BH_Core.Controls.Component.BhLabel bhLabel1;
        private BH_Core.Controls.Component.BhButton btnExport;
        private BH_Core.Controls.Component.BhTextBox txtPath;
        private BH_Core.Controls.Component.BhButton btnOpenFile;
        private BH_Core.Controls.Component.BhButton btnSetYear;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private BH_Core.Controls.Component.BhLabel bhLabel10;
        private System.Windows.Forms.DateTimePicker dtStart;
    }
}