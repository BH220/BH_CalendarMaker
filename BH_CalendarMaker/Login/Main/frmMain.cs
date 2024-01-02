using BH_CalendarMaker.Anniversary;
using BH_CalendarMaker.Data;
using BH_CalendarMaker.Login;
using BH_CalendarMaker.Properties;
using BH_Core;
using BH_Core.Config;
using BH_Core.Forms;
using BH_Core.Interface;
using BH_Core.SessionInfo;
using BH_Library.GlobalHock;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_CalendarMaker.Main
{

    public partial class frmMain : Form
    {
        #region 변수,프로퍼티
        bool ProgramExitFlag = false;//true면 종료 false면 트레이로
        List<ToolStripButton> listTopMenuBtn = null;
        public List<ToolStripButton> TopMenuList
        {
            get
            {
                if (listTopMenuBtn == null)
                {
                    listTopMenuBtn = new List<ToolStripButton>();
                    //listTopMenuBtn.Add(btnNewMessage);
                    //listTopMenuBtn.Add(btnInput);
                    //listTopMenuBtn.Add(btnReport);
                    //listTopMenuBtn.Add(btnBasic);
                }
                return listTopMenuBtn;
            }
        } 
        BhForm nowActiveForm = null;
        GlobalDetecting GlobalDetecting = null;
        #endregion

        #region 생성자
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 초기화 오버라이드
        protected override void OnClosing(CancelEventArgs e)
        {
            if (ProgramExitFlag)
            {
                if (Config.IsExitPossible == false)
                {
                    Common.ApplicationExitFlag = true;
                }
                else if (Common.ApplicationExit())
                {
                    Common.ApplicationExitFlag = true;
                    Config.IsExitPossible = true;
                }
                else
                {
                    Config.IsExitPossible = true;
                    e.Cancel = true;
                }
            }
            else
            {
                if (Common.ApplicationExitFlag == false)
                {
                    e.Cancel = true;
                    this.Visible = false;
                    trayIcon.Visible = true;
                    return;
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Common.ApplicationExitFlag = false;
            mainTimer.Start();
            lbInfo.Text = string.Format("{0} 님 로그인 중..", SessionHelper.Instance.UserInfo.UserName);
            infoUser.Text = string.Format("접속자:{0}[{1}]", SessionHelper.Instance.UserInfo.UserName, SessionHelper.Instance.UserInfo.UserId);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Icon = Resources.Main;
            this.trayIcon.Icon = Resources.Main;
#if DEBUG
#else
            GlobalDetecting = new GlobalDetecting(SessionManager.Instance.OptionInfo.자동잠금화면대기시간);
            GlobalDetecting.StopDetecting += GlobalDetecting_StopDetecting;
            if (SessionManager.Instance.OptionInfo.자동잠금사용여부 == 사용여부.사용함)
                GlobalDetecting.Start();
#endif
            
        }
        #endregion

        #region 기타이벤트 

        void frm_ShowMainFormEvent(object sender, bool isShow)
        {

        }
        private int escClick = 0;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            //if (e.Alt)
            //{
            //    switch (e.KeyCode)
            //    {
            //        //case Keys.M: TopMenuClick(btnNewMessage, null); return;
            //        case Keys.I: TopMenuClick(btnInsert, null); return;
            //        //case Keys.R: TopMenuClick(btnNewMessage, null); return;
            //        case Keys.B: TopMenuClick(btnBasic, null); return;
            //        case Keys.O: lbLogOut_LinkClicked(null, null); return;
            //        case Keys.L: TopMenuClick(btnLock, null); return;
            //        case Keys.H: btnAbout_Click(null, null); return;
            //    }
            //}
            //if (e.Control && e.Shift)
            //{
            //    switch (e.KeyCode)
            //    {
            //        case Keys.N: LeftMenuClick(btnMessage, null); return;
            //        case Keys.O: if (btnOil.Visible) LeftMenuClick(btnOil, null); return;
            //        case Keys.R: if (btnTire.Visible) LeftMenuClick(btnMessage, null); return;
            //        case Keys.T: if (btnTerm.Visible) LeftMenuClick(btnTerm, null); return;
            //        case Keys.P: if (btnBuy.Visible) LeftMenuClick(btnBuy, null); return;
            //        case Keys.W: if (btnWash.Visible) LeftMenuClick(btnWash, null); return;
            //        case Keys.C:
            //            if (btnChangeOil.Visible) LeftMenuClick(btnChangeOil, null);
            //            else if (btnConsumables.Visible) LeftMenuClick(btnConsumables, null);
            //            return;
            //        case Keys.F: if (btnFixed.Visible) LeftMenuClick(btnFixed, null); return;
            //        //case Keys.A: if (btnRecordAll.Visible) LeftMenuClick(btnRecordAll, null); return;
            //        case Keys.M: if (btnCar.Visible) LeftMenuClick(btnCar, null); return;
            //        case Keys.H: if (btnShop.Visible) LeftMenuClick(btnShop, null); return;
            //        case Keys.S: if (btnSetting.Visible) LeftMenuClick(btnSetting, null); return;
            //    }
            //}

            switch (e.KeyCode)
            {
                //case Keys.F1: if (btnSale.Enabled) RunFunction(Functions.매출); break;
                //case Keys.F2: if (btnBuy.Enabled) RunFunction(Functions.매입); break;
                //case Keys.F3: if (btnInMoney.Enabled) RunFunction(Functions.입금); break;
                //case Keys.F4: if (btnOutMoney.Enabled) RunFunction(Functions.출금); break;

                case Keys.F5: if (btnRefresh.Enabled) RunFunction(Functions.갱신); break;
                case Keys.F6: if (btnSearch.Enabled) RunFunction(Functions.검색); break;
                case Keys.F7: if (btnCopy.Enabled) RunFunction(Functions.복사); break;
                case Keys.F8: if (btnUpdate.Enabled) RunFunction(Functions.수정); break;

                //case Keys.F9: 비어있음
                //case Keys.F10: 비어있음
                case Keys.F11: if (btnExcel.Enabled) RunFunction(Functions.엑셀); break;
                case Keys.F12: if (btnPrint.Enabled) RunFunction(Functions.인쇄); break;
                case Keys.Insert: if (btnInsert.Enabled) RunFunction(Functions.추가); break;
                case Keys.Delete: if (btnDelete.Enabled) RunFunction(Functions.삭제); break;
                case Keys.Escape:
                    if (btnClose.Enabled)
                    {
                        if (escClick > 0)
                            CloseForm();
                        else
                            escClick++;
                    }
                    break;//닫기
                default:
                    escClick = 0;
                    break;
            }
        }
        void GlobalDetecting_StopDetecting(object sender, int stopSecond, DateTime dectectingTime)
        {
            GlobalDetecting.Stop();
            ShowForm(Menus.화면잠금);
        }
        void frm_CommandButtonEnableChanged(object sender, BhCommandButtonEnableEventArgs e)
        {
            ToolStripButton btn = null;
            switch (e.ButtonType)
            {
                case CommandToolbarButton.Insert: btn = btnInsert; break;
                case CommandToolbarButton.Update: btn = btnUpdate; break;
                case CommandToolbarButton.Delete: btn = btnDelete; break;
                case CommandToolbarButton.Copy: btn = btnCopy; break;
                case CommandToolbarButton.Refresh: btn = btnRefresh; break;
                case CommandToolbarButton.Search: btn = btnSearch; break;
                case CommandToolbarButton.Excel: btn = btnExcel; break;
                case CommandToolbarButton.Print: btn = btnPrint; break;
                case CommandToolbarButton.Exit: btn = btnClose; break;
            }
            if (btn != null)
                btn.Enabled = e.IsEnable;
        }
        void frm_StatusTextChangeEvent(IBhForm frm, string StatusText)
        {
            infoTip.Text = StatusText;
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BhForm frm = sender as BhForm;
            if (frm == null)
                return;
            if (frm.MenuID == Menus.설정)
            {
                if (SessionHelper.Instance.OptionInfo.자동잠금사용여부 == 사용여부.사용함)
                    GlobalDetecting.ChangeInterval(SessionHelper.Instance.OptionInfo.자동잠금화면대기시간);
            }
        }
        #endregion

        #region 상단 단축 버튼

        private void FunctionBtn_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            if (tsb == null)
                return;
            RunFunction(tsb.Tag.ToStringEx());
        }

        private void CustomBtn_Click(object sender, EventArgs e)
        {

        }

        private void RunFunction(string functionId)
        {
            BhForm bhForm = null;

            switch (functionId)
            {
                //case Functions.매출: ShowForm(Menus.매출관리); break;
                //case Functions.매입: ShowForm(Menus.매입관리); break;
                //case Functions.입금: ShowForm(Menus.입금관리); break;
                //case Functions.출금: ShowForm(Menus.출금관리); break;
                case Functions.닫기: CloseForm(); break;
                default:
                    if (nowActiveForm != null)
                        bhForm = nowActiveForm as BhForm;
                    break;
            }

            if (bhForm != null)
            {
                switch (functionId)
                {
                    case Functions.추가: bhForm.InsertData(); break;
                    case Functions.수정: bhForm.UpdateData(); break;
                    case Functions.삭제: bhForm.DeleteData(); break;
                    case Functions.복사: bhForm.CopyData(); break;
                    case Functions.갱신: bhForm.RefreshData(); break;
                    case Functions.검색: bhForm.SearchData(); break;
                    case Functions.엑셀: bhForm.ExportExcel(); break;
                    case Functions.인쇄: bhForm.ExportPrint(); break;
                }
            }
        }

        #endregion

        #region 버튼이벤트 
          
        private void lbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(Menus.로그아웃);
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        { 
            ShowForm(Menus.프로그램정보);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            if (tsmi == null)
                return;
            ShowForm(tsmi.Tag.ToStringEx());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ProgramExitFlag = true;
            Close();
        }
        #endregion

        #region 사용자함수

        private void ScreenLock()
        {
            using (frmLock frm = new frmLock())
            {
                frm.ShowMainFormEvent += frm_ShowMainFormEvent;
                trayIcon.Visible = false;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Visible = true;
                    Common.ScreenLockFlag = false;
#if DEBUG
#else 
                    GlobalDetecting.Start();
#endif
                }
                else
                    trayIcon.Visible = true;
            }
        }

        private void CloseForm(bool toolStripBtnDisable = true)
        {
            if (nowActiveForm != null)
            {
                nowActiveForm.Close();
                nowActiveForm.Dispose();
                if (toolStripBtnDisable)
                    SetToolStripButton(false);
            } 
        }

        private void SetToolStripButton(bool isEnable)
        {
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnCopy.Enabled = btnRefresh.Enabled = btnSearch.Enabled = btnExcel.Enabled = btnPrint.Enabled = btnClose.Enabled = isEnable;
            btnCustom1.Enabled = btnCustom1.Visible = false;
        }

        private void ShowForm(string menuId)
        {
            escClick = 0;
            BhForm frm = null;
            switch (menuId)
            {
                case Menus.기념일관리: frm = new frmAnniversaryList(); break;
                case Menus.달력으로보기: frm = new frmCalendarView(); break;
                //case Menus.주유: frm = new frmOilList(); break;
                //case Menus.설정: frm = new frmSettingCommon(); break;
                //case Menus.차량관리:
                //    frm = new frmCarList();
                //    frm.MainCallFormEvent += Frm_MainCallFormEvent;
                //    break;
                //case Menus.가게: frm = new frmShopList(); break;
                //case Menus.소모품: frm = new frmConsumableList(); break;
                //case Menus.공기압: frm = new frmAirPressureList(); break;
                //case Menus.세차: frm = new frmCarWashList(); break;
                //case Menus.구매: frm = new frmPurchaseList(); break;
                //case Menus.정비: frm = new frmFixedList(); break;
                //case Menus.교환주기: frm = new frmTermList(); break;
            }

            bool showMsg = true;
            if (frm != null)
            {
                CloseForm(false);
                SetToolStripButton(true);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.CommandButtonEnableChanged += frm_CommandButtonEnableChanged;
                frm.StatusTextChangeEvent += frm_StatusTextChangeEvent;
                frm.CustomFunctionSettingEvent += Frm_CustomFunctionSettingEvent;
                frm.FormClosed += frm_FormClosed;
                nowActiveForm = frm;
                showMsg = false;
                frm.Show();
            }

            //특별 처리 메뉴
            switch (menuId)
            {
                case Menus.설정:
#if DEBUG
#else 
                    if (SessionHelper.Instance.OptionInfo.자동잠금사용여부 == 사용여부.사용함)
                        GlobalDetecting.ReStart();
                    else
                        GlobalDetecting.Stop();
#endif
                    showMsg = false;
                    break;
                case Menus.프로그램정보:
                    frmAbout aboutForm = new frmAbout("Best Comfortable And Easy Books.");
                    aboutForm.ShowDialog();
                    showMsg = false;
                    break;
                case Menus.화면잠금:
                    Common.ApplicationExitFlag = false;
                    Common.ScreenLockFlag = true;
                    showMsg = false;
                    this.Close();
                    ScreenLock();
                    break;
                case Menus.로그아웃:
                    showMsg = false;
                    LogOut();
                    break;
                case Menus.프로그램종료:
                    showMsg = false;
                    ApplicaionExit();
                    break;
            }

            if (showMsg)
                BhMsgBox.Error(string.Format("[{0}] 메뉴는 현재 준비중 입니다.", menuId));
        }

        private void Frm_CustomFunctionSettingEvent(object sender, CustomFunctionSettingEventArgs e)
        {
            switch (e.ButtonType)
            {
                case CustomFunctionButton.Custom1:
                    btnCustom1.Enabled = true;
                    btnCustom1.Text = e.Title;
                    btnCustom1.Visible = true;
                    break;
            }
        }

        private void Frm_MainCallFormEvent(object obj)
        {
           
        }

        private void LogOut()
        {
            Config.IsExitPossible = false;
            Common.ApplicationExitFlag = true;
            Close();
        }

        private void ApplicaionExit()
        {
            if (Common.ApplicationExit())
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }


        #endregion
        
        private void mainTimer_Tick(object sender, EventArgs e)
        {

        }

        private void infoTip_DoubleClick(object sender, EventArgs e)
        {
            nowActiveForm.StatusInfoDoubleClick(null);
        }
    }
}
