using BH_CalendarMaker.Data;
using BH_CalendarMaker.Interface.Helper.Code;
using BH_Core;
using BH_Core.Forms;
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
    public partial class frmAnniversaryList : BhForm
    {
        SqlManager sqlManager = null;

        public frmAnniversaryList()
        {
            this.MenuID = Menus.기념일관리;
            InitializeComponent();
        }


        public override void OnSetInitControl()
        {
            base.OnSetInitControl();
            this.FunctionButtonEnableChanged(CommandToolbarButton.Copy, false);
            this.FunctionButtonEnableChanged(CommandToolbarButton.Print, false);
        }

        public override void OnSetInitGrid()
        {
            base.OnSetInitGrid();
            InitGrid();
        }

        public override void OnSetInitData()
        {
            base.OnSetInitData();
            sqlManager = new SqlManager();
            DataLoad();
        }

        private void InitGrid()
        {
            bhGrid.AddColumn("id", "id", 80, FieldType.ShortDate, FieldAlign.Center, false, false);
            bhGrid.AddColumn("기념일", "dateEx", 70, FieldType.Text, FieldAlign.Center, true);
            bhGrid.AddColumn("양음력", "dateTypeEx", 70, FieldType.Text, FieldAlign.Center, true);
            bhGrid.AddColumn("기념일명", "name", 200, FieldType.Text, FieldAlign.Near, true);
            bhGrid.AddColumn("구분", "categoryEx", 70, FieldType.Text, FieldAlign.Center, true);
            bhGrid.AddColumn("반복", "repeatTypeEx", 70, FieldType.Text, FieldAlign.Center, true);
            bhGrid.AddColumn("내용", "contents", 70, FieldType.Text, FieldAlign.Near, false);
        }

        private void DataLoad()
        {
            int preIndex = -1;
            if (bhGrid.SelectedRows.Count > 0)
                preIndex = bhGrid.SelectedRows[0].Index;
            CodeType_기념일구분 ct = CodeType_기념일구분.None;
            if (rbHollyDay.Checked) ct = CodeType_기념일구분.국가공휴일;
            else if (rbBirthDay.Checked) ct = CodeType_기념일구분.생일;
            else if (rbSpecialDay.Checked) ct = CodeType_기념일구분.기념일;
            else if (rbTask.Checked) ct = CodeType_기념일구분.일정;
            else if (rbMoon.Checked) ct = CodeType_기념일구분.절기;

            DataTable result = sqlManager.SELECT_ANNIVERSARY_LIST_SEARCH(ct);
            if (result != null && result.Rows.Count>0)
            {
                bhGrid.SetDataSource(result);
                bhGrid.Refresh();
            }
            if (preIndex > 0)
            {
                if (bhGrid.Rows.Count > 0)
                {
                    if (bhGrid.Rows.Count - 1 < preIndex)
                        preIndex = bhGrid.Rows.Count - 1;
                    bhGrid.SetFocuseRow(preIndex);
                }
            }
        }

        protected override void OnSysUpdate()
        {
            base.OnSysUpdate();
            DataRow row = bhGrid.GetFocusedDataRow();
            if (row != null)
                InsertOrUpdate(row["id"].ToIntEx());
        }

        protected override void OnSysLoadData()
        {
            DataLoad();
        }

        protected override void OnSysInsert()
        {
            InsertOrUpdate();
        }

        protected override void OnSysDelete()
        {
            base.OnSysDelete();
            DataRow row = bhGrid.GetFocusedDataRow();
            if (row == null)
            {
                BhMsgBox.Warning("삭제할 자료가 선택되지 않았습니다.");
                return;
            }
            if (Common.DeleteConfirm() == false)
                return;
            int id = row["id"].ToIntEx();
            string errMsg = sqlManager.DELETE_ANNIVERSARY(id);
            if (string.IsNullOrEmpty(errMsg))
                DataLoad();
            else
                BhMsgBox.Error(errMsg);
        }

        private void InsertOrUpdate(int id = -1)
        {
            using (frmAnniversaryInfo info = new frmAnniversaryInfo())
            {
                info.ID = id;
                info.OnSavedData += info_OnSavedData;
                info.ShowDialog();
            }
        }

        bool info_OnSavedData(object sender, bool isSave, bool isRefresh = true)
        {
            if (isSave || isRefresh)
                DataLoad();
            return true;
        }


        protected override void OnSysSearch()
        {
            bhSearchBox1.SetSearchTextFocus();
        }

        private void bhSearchBox1_SearchEvent(object sender, SearchDataEventAgrs e)
        {
            bhGrid.SearchText(e.SearchText);
        }

        protected override void OnSysPrint()
        {
            base.OnSysPrint();
            //Print();
        }

        protected override void OnSysExcel()
        {
            base.OnSysExcel();
            ExcelHelper.ExportExcel(this, "기념일 기록", bhGrid);
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
