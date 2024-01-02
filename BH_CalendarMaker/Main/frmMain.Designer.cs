namespace BH_CalendarMaker.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.프로그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비밀번호변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.트레이로보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기념일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기념일관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.달력으로보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구분색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bHCalendarMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.infoUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCustom1 = new System.Windows.Forms.ToolStripButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.차계부열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램ToolStripMenuItem,
            this.기념일ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 프로그램ToolStripMenuItem
            // 
            this.프로그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.비밀번호변경ToolStripMenuItem,
            this.toolStripSeparator1,
            this.트레이로보내기ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.프로그램종료ToolStripMenuItem});
            this.프로그램ToolStripMenuItem.Name = "프로그램ToolStripMenuItem";
            this.프로그램ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.프로그램ToolStripMenuItem.Text = "프로그램(&F)";
            // 
            // 비밀번호변경ToolStripMenuItem
            // 
            this.비밀번호변경ToolStripMenuItem.Name = "비밀번호변경ToolStripMenuItem";
            this.비밀번호변경ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.비밀번호변경ToolStripMenuItem.Tag = "S102";
            this.비밀번호변경ToolStripMenuItem.Text = "비밀번호 변경";
            this.비밀번호변경ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // 트레이로보내기ToolStripMenuItem
            // 
            this.트레이로보내기ToolStripMenuItem.Name = "트레이로보내기ToolStripMenuItem";
            this.트레이로보내기ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.트레이로보내기ToolStripMenuItem.Tag = "S101";
            this.트레이로보내기ToolStripMenuItem.Text = "트레이로 보내기";
            this.트레이로보내기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.로그아웃ToolStripMenuItem.Tag = "S104";
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.프로그램종료ToolStripMenuItem.Tag = "S105";
            this.프로그램종료ToolStripMenuItem.Text = "프로그램 종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 기념일ToolStripMenuItem
            // 
            this.기념일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기념일관리ToolStripMenuItem,
            this.달력으로보기ToolStripMenuItem});
            this.기념일ToolStripMenuItem.Name = "기념일ToolStripMenuItem";
            this.기념일ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.기념일ToolStripMenuItem.Text = "기념일(&D)";
            // 
            // 기념일관리ToolStripMenuItem
            // 
            this.기념일관리ToolStripMenuItem.Name = "기념일관리ToolStripMenuItem";
            this.기념일관리ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.기념일관리ToolStripMenuItem.Tag = "D101";
            this.기념일관리ToolStripMenuItem.Text = "기념일 관리";
            this.기념일관리ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 달력으로보기ToolStripMenuItem
            // 
            this.달력으로보기ToolStripMenuItem.Name = "달력으로보기ToolStripMenuItem";
            this.달력으로보기ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.달력으로보기ToolStripMenuItem.Tag = "D102";
            this.달력으로보기ToolStripMenuItem.Text = "달력으로 보기";
            this.달력으로보기ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구분색상ToolStripMenuItem,
            this.옵션ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.설정ToolStripMenuItem.Text = "설정(&S)";
            // 
            // 구분색상ToolStripMenuItem
            // 
            this.구분색상ToolStripMenuItem.Name = "구분색상ToolStripMenuItem";
            this.구분색상ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.구분색상ToolStripMenuItem.Tag = "O103";
            this.구분색상ToolStripMenuItem.Text = "구분 색상";
            this.구분색상ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.옵션ToolStripMenuItem.Tag = "O104";
            this.옵션ToolStripMenuItem.Text = "옵션";
            this.옵션ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bHCalendarMakerToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // bHCalendarMakerToolStripMenuItem
            // 
            this.bHCalendarMakerToolStripMenuItem.Image = global::BH_CalendarMaker.Properties.Resources.도움말;
            this.bHCalendarMakerToolStripMenuItem.Name = "bHCalendarMakerToolStripMenuItem";
            this.bHCalendarMakerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bHCalendarMakerToolStripMenuItem.Tag = "H101";
            this.bHCalendarMakerToolStripMenuItem.Text = "BH CalendarMaker";
            this.bHCalendarMakerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoTip,
            this.lbInfo,
            this.toolStripProgressBar1,
            this.infoUser,
            this.lbTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoTip
            // 
            this.infoTip.DoubleClickEnabled = true;
            this.infoTip.Name = "infoTip";
            this.infoTip.Size = new System.Drawing.Size(0, 17);
            // 
            // lbInfo
            // 
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(859, 17);
            this.lbInfo.Spring = true;
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // infoUser
            // 
            this.infoUser.Name = "infoUser";
            this.infoUser.Size = new System.Drawing.Size(85, 17);
            this.infoUser.Text = "관리자(admin)";
            // 
            // lbTime
            // 
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(125, 17);
            this.lbTime.Text = "1987-05-01 11:40:00";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.btnCopy,
            this.btnClose,
            this.toolStripSeparator10,
            this.btnPrint,
            this.btnExcel,
            this.btnSearch,
            this.btnRefresh,
            this.toolStripSeparator11,
            this.toolStripSeparator12,
            this.btnCustom1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1084, 28);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(11, 25);
            this.toolStripLabel3.Text = " ";
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(61, 25);
            this.btnInsert.Tag = "Ins";
            this.btnInsert.Text = "추가(Ins)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnInsert.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 25);
            this.btnUpdate.Tag = "F8";
            this.btnUpdate.Text = "수정(F8)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnUpdate.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 25);
            this.btnDelete.Tag = "Del";
            this.btnDelete.Text = "삭제(Del)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnDelete.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(61, 25);
            this.btnCopy.Tag = "F7";
            this.btnCopy.Text = "복사(F7)";
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnCopy.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.Enabled = false;
            this.btnClose.Image = global::BH_CalendarMaker.Properties.Resources.btn7;
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 25);
            this.btnClose.Tag = "ESC";
            this.btnClose.Text = "닫기(ESC)";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnClose.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 28);
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 25);
            this.btnPrint.Tag = "F12";
            this.btnPrint.Text = "인쇄(F12)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExcel.Enabled = false;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(63, 25);
            this.btnExcel.Tag = "F11";
            this.btnExcel.Text = "엑셀(F11)";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnExcel.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSearch.Enabled = false;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 25);
            this.btnSearch.Tag = "F6";
            this.btnSearch.Text = "검색(F6)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnSearch.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 25);
            this.btnRefresh.Tag = "F5";
            this.btnRefresh.Text = "갱신(F5)";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnRefresh.Click += new System.EventHandler(this.FunctionBtn_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 28);
            // 
            // btnCustom1
            // 
            this.btnCustom1.Enabled = false;
            this.btnCustom1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustom1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustom1.Name = "btnCustom1";
            this.btnCustom1.Size = new System.Drawing.Size(42, 25);
            this.btnCustom1.Tag = "CUST1";
            this.btnCustom1.Text = "기능1";
            this.btnCustom1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnCustom1.Visible = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            // 
            // trayMenu
            // 
            this.trayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.차계부열기ToolStripMenuItem,
            this.toolStripSeparator6,
            this.toolStripMenuItem1,
            this.toolStripSeparator7,
            this.toolStripMenuItem2});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(151, 82);
            // 
            // 차계부열기ToolStripMenuItem
            // 
            this.차계부열기ToolStripMenuItem.Name = "차계부열기ToolStripMenuItem";
            this.차계부열기ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.차계부열기ToolStripMenuItem.Text = "차계부 열기";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Text = "로그아웃";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "프로그램 종료";
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Text = "BH차계부";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BH 기념일 달력 만들기";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 프로그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기념일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbInfo;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel infoUser;
        private System.Windows.Forms.ToolStripStatusLabel lbTime;
        private System.Windows.Forms.ToolStripMenuItem 트레이로보내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비밀번호변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bHCalendarMakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기념일관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구분색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btnCustom1;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem 차계부열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ToolStripStatusLabel infoTip;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 달력으로보기ToolStripMenuItem;
    }
}