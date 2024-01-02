using BH_CalendarMaker.Data;
using BH_CalendarMaker.Interface.Helper.Anniversary;
using BH_CalendarMaker.Interface.Helper.Code;
using BH_CalendarMaker.Interface.Model;
using BH_Core;
using BH_Core.Forms;
using BH_Core.WaitingForm;
using BH_Library.Utils;
using BH_Report; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_CalendarMaker.Anniversary
{
    public partial class frmCalendarView : BhForm
    { 
        List<AnniversaryModel> AnniversaryList = new List<AnniversaryModel>();

        public frmCalendarView()
        {
            this.MenuID = Menus.달력으로보기;
            InitializeComponent();
        }


        public override void OnSetInitControl()
        {
            base.OnSetInitControl();
            this.FunctionButtonEnableChanged(CommandToolbarButton.Copy, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Print, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Insert, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Update, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Delete, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Search, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Refresh, false);
        }

        public override void OnSetInitGrid()
        {
            base.OnSetInitGrid(); 
        }

        public override void OnSetInitData()
        {
            base.OnSetInitData();
        }

        protected override void OnShown(EventArgs e)
        {
            LoadData(true);
            base.OnShown(e);
        }

        protected override void OnSysExcel()
        {
            base.OnSysExcel();
            using (frmExportExcel frm = new frmExportExcel(AnniversaryList))
            {
                frm.ShowDialog();
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(bool isRefresh = false)
        {
            DateTime sdt = new DateTime(dateTimePicker1.Value.Year - 1, 12, 15);
            DateTime edt = new DateTime(dateTimePicker1.Value.Year + 1, 1, 15);
            GetAnniversary(sdt, edt, isRefresh);
            ctlCalendarView1.LoadData(dateTimePicker1.Value, AnniversaryList);
        }

        private void GetAnniversary(DateTime start, DateTime end, bool isRefresh)
        {
            if (isRefresh)
            {
                AnniversaryList = new List<AnniversaryModel>();
                using (var db = new BH_CalendarMakerContext())
                {
                    var lst = db.BHR_Anniversaries.Where(x => x.enable == 1);
                    AnniversaryModel model = null;
                    foreach (var md in lst)
                    {
                        model = new AnniversaryModel();
                        model.date = md.date.Length == 8 ? md.date.Substring(4, 4) : "";
                        model.CategoryType = (CodeType_기념일구분)md.category;
                        model.RepeatType = (CodeType_반복구분)md.repeatType;
                        model.DateType = (CodeType_날짜구분)md.dateType;
                        model.name = md.name;
                        if (model.DateType == CodeType_날짜구분.음력) model.name = "(음)" + model.name;
                        model.contents = md.contents;
                        AnniversaryList.Add(model);
                    }
                }
            }
            int y = start.Year + 1;
            int 추석 = AnniversaryList.Count(x => x.Anniversary.Year == y && x.name.Contains("추석"));
            if (추석 == 0)
            {
                WaitFormInfo wfi = new WaitFormInfo();
                wfi.Work = WorkType.Start;
                wfi.Title = "기념일 정보 조회";
                wfi.Content = "공공데이터API를 통해 자료를 수집중 입니다.";
                wfi.CenterScreen = false;
                MainFormCall(wfi);
                AnniversaryHelper helper = new AnniversaryHelper(AnniversaryList);
                AnniversaryList = helper.GetAnniversaryList(start, end);
                wfi.Work = WorkType.End;
                MainFormCall(wfi);
            }
        }

        public override void MainFormCall(object obj)
        {
            base.MainFormCall(obj);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData(true);
        }
    }
}
