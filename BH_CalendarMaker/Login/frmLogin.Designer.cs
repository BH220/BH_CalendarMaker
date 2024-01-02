namespace BH_CalendarMaker.Login
{
    partial class frmLogin
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
            this.chkSaveInfo = new BH_Core.Controls.Component.BhCheckBox();
            this.txtPw = new BH_Core.Controls.Component.BhTextBox();
            this.txtId = new BH_Core.Controls.Component.BhTextBox();
            this.bhLabel2 = new BH_Core.Controls.Component.BhLabel();
            this.bhLabel1 = new BH_Core.Controls.Component.BhLabel();
            this.btnLogin = new BH_Core.Controls.Component.BhButton();
            this.btnClose = new BH_Core.Controls.Component.BhButton();
            this.bhLabel3 = new BH_Core.Controls.Component.BhLabel();
            this.SuspendLayout();
            // 
            // chkSaveInfo
            // 
            this.chkSaveInfo.AutoSize = true;
            this.chkSaveInfo.BackColor = System.Drawing.Color.Transparent;
            this.chkSaveInfo.BhGroupName = null;
            this.chkSaveInfo.EditValue = false;
            this.chkSaveInfo.Location = new System.Drawing.Point(237, 116);
            this.chkSaveInfo.Name = "chkSaveInfo";
            this.chkSaveInfo.RequireValueError = null;
            this.chkSaveInfo.Size = new System.Drawing.Size(88, 16);
            this.chkSaveInfo.TabIndex = 20;
            this.chkSaveInfo.Text = "자동 로그인";
            this.chkSaveInfo.UseVisualStyleBackColor = false;
            this.chkSaveInfo.CheckedChanged += new System.EventHandler(this.chkSaveInfo_CheckedChanged);
            // 
            // txtPw
            // 
            this.txtPw.BhGroupName = null;
            this.txtPw.EditValue = "";
            this.txtPw.Location = new System.Drawing.Point(237, 89);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.RequireValueError = null;
            this.txtPw.SearchButtonEnable = true;
            this.txtPw.SearchButtonVisible = false;
            this.txtPw.Size = new System.Drawing.Size(232, 21);
            this.txtPw.TabIndex = 18;
            this.txtPw.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtPw.WaterMarkText = "";
            this.txtPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // txtId
            // 
            this.txtId.BhGroupName = null;
            this.txtId.EditValue = "";
            this.txtId.Location = new System.Drawing.Point(237, 62);
            this.txtId.Name = "txtId";
            this.txtId.RequireValueError = null;
            this.txtId.SearchButtonEnable = true;
            this.txtId.SearchButtonVisible = false;
            this.txtId.Size = new System.Drawing.Size(232, 21);
            this.txtId.TabIndex = 17;
            this.txtId.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtId.WaterMarkText = "";
            // 
            // bhLabel2
            // 
            this.bhLabel2.AutoSize = true;
            this.bhLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bhLabel2.BhGroupName = "";
            this.bhLabel2.EditValue = "PW";
            this.bhLabel2.IsRequireValue = false;
            this.bhLabel2.Location = new System.Drawing.Point(192, 93);
            this.bhLabel2.Name = "bhLabel2";
            this.bhLabel2.RequireValueError = "";
            this.bhLabel2.Size = new System.Drawing.Size(23, 12);
            this.bhLabel2.TabIndex = 16;
            this.bhLabel2.Text = "PW";
            this.bhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bhLabel1
            // 
            this.bhLabel1.AutoSize = true;
            this.bhLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bhLabel1.BhGroupName = "";
            this.bhLabel1.EditValue = "ID";
            this.bhLabel1.IsRequireValue = false;
            this.bhLabel1.Location = new System.Drawing.Point(192, 66);
            this.bhLabel1.Name = "bhLabel1";
            this.bhLabel1.RequireValueError = "";
            this.bhLabel1.Size = new System.Drawing.Size(16, 12);
            this.bhLabel1.TabIndex = 15;
            this.bhLabel1.Text = "ID";
            this.bhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BhGroupName = null;
            this.btnLogin.EditValue = null;
            this.btnLogin.Image = global::BH_CalendarMaker.Properties.Resources.Login;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(237, 138);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RequireValueError = null;
            this.btnLogin.Size = new System.Drawing.Size(66, 23);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "    로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BhGroupName = null;
            this.btnClose.EditValue = null;
            this.btnClose.Image = global::BH_CalendarMaker.Properties.Resources.닫기_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(309, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.RequireValueError = null;
            this.btnClose.Size = new System.Drawing.Size(66, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "    닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bhLabel3
            // 
            this.bhLabel3.AutoSize = true;
            this.bhLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bhLabel3.BhGroupName = "";
            this.bhLabel3.EditValue = "BH 기념일 달력 만들기";
            this.bhLabel3.Font = new System.Drawing.Font("궁서", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bhLabel3.IsRequireValue = false;
            this.bhLabel3.Location = new System.Drawing.Point(192, 23);
            this.bhLabel3.Name = "bhLabel3";
            this.bhLabel3.RequireValueError = "";
            this.bhLabel3.Size = new System.Drawing.Size(269, 24);
            this.bhLabel3.TabIndex = 23;
            this.bhLabel3.Text = "BH 기념일 달력 만들기";
            this.bhLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BH_CalendarMaker.Properties.Resources.loginBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 185);
            this.Controls.Add(this.bhLabel3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkSaveInfo);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bhLabel2);
            this.Controls.Add(this.bhLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BH차계부 - 로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BH_Core.Controls.Component.BhButton btnLogin;
        private BH_Core.Controls.Component.BhButton btnClose;
        private BH_Core.Controls.Component.BhCheckBox chkSaveInfo;
        private BH_Core.Controls.Component.BhTextBox txtPw;
        private BH_Core.Controls.Component.BhTextBox txtId;
        private BH_Core.Controls.Component.BhLabel bhLabel2;
        private BH_Core.Controls.Component.BhLabel bhLabel1;
        private BH_Core.Controls.Component.BhLabel bhLabel3;
    }
}