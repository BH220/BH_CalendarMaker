
namespace BH_CalendarMaker.Anniversary
{
    partial class ctlDay
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.txtContent = new BH_Core.Controls.Component.BhTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDay = new BH_Core.Controls.Component.BhLabel();
            this.lbMinseo = new System.Windows.Forms.Label();
            this.lbTwins = new System.Windows.Forms.Label();
            this.lbMoon = new System.Windows.Forms.Label();
            this.bhLabel2 = new BH_Core.Controls.Component.BhLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.BhGroupName = null;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.EditValue = "";
            this.txtContent.Location = new System.Drawing.Point(6, 54);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.RequireValueError = null;
            this.txtContent.SearchButtonEnable = false;
            this.txtContent.SearchButtonVisible = false;
            this.txtContent.Size = new System.Drawing.Size(122, 43);
            this.txtContent.TabIndex = 1;
            this.txtContent.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtContent.WaterMarkText = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lbDay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbMinseo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTwins, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbMoon, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(128, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbDay
            // 
            this.lbDay.BhGroupName = "";
            this.lbDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDay.EditValue = "31";
            this.lbDay.Font = new System.Drawing.Font("굴림", 38F, System.Drawing.FontStyle.Bold);
            this.lbDay.IsRequireValue = false;
            this.lbDay.Location = new System.Drawing.Point(0, 0);
            this.lbDay.Margin = new System.Windows.Forms.Padding(0);
            this.lbDay.Name = "lbDay";
            this.lbDay.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lbDay.RequireValueError = "";
            this.tableLayoutPanel1.SetRowSpan(this.lbDay, 3);
            this.lbDay.Size = new System.Drawing.Size(88, 50);
            this.lbDay.TabIndex = 6;
            this.lbDay.Text = "31";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMinseo
            // 
            this.lbMinseo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMinseo.Location = new System.Drawing.Point(88, 0);
            this.lbMinseo.Margin = new System.Windows.Forms.Padding(0);
            this.lbMinseo.Name = "lbMinseo";
            this.lbMinseo.Size = new System.Drawing.Size(40, 16);
            this.lbMinseo.TabIndex = 7;
            this.lbMinseo.Text = "9999";
            this.lbMinseo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTwins
            // 
            this.lbTwins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTwins.Location = new System.Drawing.Point(88, 16);
            this.lbTwins.Margin = new System.Windows.Forms.Padding(0);
            this.lbTwins.Name = "lbTwins";
            this.lbTwins.Size = new System.Drawing.Size(40, 16);
            this.lbTwins.TabIndex = 8;
            this.lbTwins.Text = "9999";
            this.lbTwins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMoon
            // 
            this.lbMoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMoon.Location = new System.Drawing.Point(88, 32);
            this.lbMoon.Margin = new System.Windows.Forms.Padding(0);
            this.lbMoon.Name = "lbMoon";
            this.lbMoon.Size = new System.Drawing.Size(40, 18);
            this.lbMoon.TabIndex = 9;
            this.lbMoon.Text = "12.30";
            this.lbMoon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bhLabel2
            // 
            this.bhLabel2.BackColor = System.Drawing.Color.Black;
            this.bhLabel2.BhGroupName = "";
            this.bhLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bhLabel2.EditValue = "";
            this.bhLabel2.Font = new System.Drawing.Font("굴림", 1F);
            this.bhLabel2.IsRequireValue = false;
            this.bhLabel2.Location = new System.Drawing.Point(3, 50);
            this.bhLabel2.Name = "bhLabel2";
            this.bhLabel2.RequireValueError = "";
            this.bhLabel2.Size = new System.Drawing.Size(128, 1);
            this.bhLabel2.TabIndex = 2;
            // 
            // ctlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bhLabel2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(134, 100);
            this.Name = "ctlDay";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Size = new System.Drawing.Size(134, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private BH_Core.Controls.Component.BhTextBox txtContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BH_Core.Controls.Component.BhLabel lbDay;
        private BH_Core.Controls.Component.BhLabel bhLabel2;
        private System.Windows.Forms.Label lbMinseo;
        private System.Windows.Forms.Label lbTwins;
        private System.Windows.Forms.Label lbMoon;
    }
}
