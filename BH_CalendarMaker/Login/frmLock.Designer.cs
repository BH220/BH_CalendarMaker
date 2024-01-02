namespace BH_CalendarMaker.Login
{
    partial class frmLock
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
            this.txtPw = new BH_Core.Controls.Component.BhTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new BH_Core.Controls.Component.BhButton();
            this.btnClose = new BH_Core.Controls.Component.BhButton();
            this.txtId = new BH_Core.Controls.Component.BhTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bhLabel3 = new BH_Core.Controls.Component.BhLabel();
            this.SuspendLayout();
            // 
            // txtPw
            // 
            this.txtPw.BhGroupName = null;
            this.txtPw.EditValue = "";
            this.txtPw.Location = new System.Drawing.Point(69, 84);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.RequireValueError = null;
            this.txtPw.SearchButtonEnable = true;
            this.txtPw.SearchButtonVisible = false;
            this.txtPw.Size = new System.Drawing.Size(129, 21);
            this.txtPw.TabIndex = 3;
            this.txtPw.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPw.WaterMarkText = "";
            this.txtPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // btnLogin
            // 
            this.btnLogin.BhGroupName = null;
            this.btnLogin.EditValue = null;
            this.btnLogin.Image = global::BH_CalendarMaker.Properties.Resources.Login;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(43, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RequireValueError = null;
            this.btnLogin.Size = new System.Drawing.Size(74, 26);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "    해  제";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BhGroupName = null;
            this.btnClose.EditValue = null;
            this.btnClose.Image = global::BH_CalendarMaker.Properties.Resources.닫기_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(124, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.RequireValueError = null;
            this.btnClose.Size = new System.Drawing.Size(74, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "    닫  기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtId
            // 
            this.txtId.BhGroupName = null;
            this.txtId.EditValue = "";
            this.txtId.Location = new System.Drawing.Point(69, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.RequireValueError = null;
            this.txtId.SearchButtonEnable = true;
            this.txtId.SearchButtonVisible = false;
            this.txtId.Size = new System.Drawing.Size(129, 21);
            this.txtId.TabIndex = 1;
            this.txtId.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtId.WaterMarkText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // bhLabel3
            // 
            this.bhLabel3.AutoSize = true;
            this.bhLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bhLabel3.BhGroupName = "";
            this.bhLabel3.EditValue = "BH 기념일 달력";
            this.bhLabel3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bhLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.bhLabel3.IsRequireValue = false;
            this.bhLabel3.Location = new System.Drawing.Point(11, 13);
            this.bhLabel3.Name = "bhLabel3";
            this.bhLabel3.RequireValueError = "";
            this.bhLabel3.Size = new System.Drawing.Size(184, 24);
            this.bhLabel3.TabIndex = 30;
            this.bhLabel3.Text = "BH 기념일 달력";
            this.bhLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(206, 147);
            this.Controls.Add(this.bhLabel3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "frmLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BH기념일달력 - 잠금해제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BH_Core.Controls.Component.BhButton btnLogin;
        private BH_Core.Controls.Component.BhButton btnClose;
        private BH_Core.Controls.Component.BhTextBox txtPw;
        private System.Windows.Forms.Label label2;
        private BH_Core.Controls.Component.BhTextBox txtId;
        private System.Windows.Forms.Label label1;
        private BH_Core.Controls.Component.BhLabel bhLabel3;
    }
}