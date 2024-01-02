using BH_CalendarMaker.Interface.Helper.Code;
using BH_Core;
using BH_Core.Controls.Component;
using BH_Core.Forms;
using BH_Core.Util;
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

namespace BH_CalendarMaker.Anniversary
{
    public partial class frmAnniversaryInfo : BhSaveForm
    {
        SqlManager sqlmanager = new SqlManager();
        #region 이벤트,델리게이트
        #endregion

        #region 변수, 프로퍼티
        bool isSaveAndRefesh = false;
        public int ID = -1;
        public DataRow preSetRow = null;
        #endregion

        #region 생성자
        public frmAnniversaryInfo()
        {
            InitializeComponent();
        }
        #endregion

        #region 초기화 오버라이드
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitControl();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
#if DEBUG
            pdpcategory.Visible =
                pdpdateType.Visible =
                pdprepeatType.Visible =
            pdpid.Visible = true;
#endif
            pdpname.Focus();
            EventCoupling();
        }

        private void InitControl()
        {
            List<Control> ctls = new List<Control>();
            foreach (Control ctl in bhPanel1.Controls)
            {
                if (ctl.Name.StartsWith("pdp"))
                {
                    ctls.Add(ctl);
                }
            }
            this.OnSetResetTargetControl(ctls.ToArray());
            LoadData();
        }
        #endregion

        #region 데이터 로드,저장,수정
        private void LoadData()
        {
            if (ID > 0)
            { //데이터 수정
                DataTable dt = sqlmanager.SELECT_ANNIVERSARY_LIST(ID);
                if (dt == null || dt.Rows.Count<=0)
                {
                    BhMsgBox.Error("기념일정보를 불러오는데 실패 하엿습니다.");
                    return;
                }
                Utility.SetDataOnFormFromDataRow(this, dt.Rows[0]);
                Text = "기념일정보 수정";
            }
            else
            {//데이터 추가
                Text = "기념일정보 추가";
            }
        }

        protected override bool OnSaveData(object sender = null, bool isSave = true, bool isRefresh = true)
        {
            if (this.IsFillOnRequireValue() == false)
                return false;
            string errMag = string.Empty; 
            try
            {
                if (ID <= 0)
                {//인서트
                    DataRow row = this.GetParamRow(this, ParamType.Insert);
                    int cate = row["category"].ToIntEx();
                    if (cate == (int)CodeType_기념일구분.국가공휴일)
                    {
                        if (BhMsgBox.Question("국가공휴일은 자동 계산되는 항목입니다.\r\n수동입력이 확실합니까?")
                            != DialogResult.Yes)
                            return false;
                    }
                    else if (cate == (int)CodeType_기념일구분.절기)
                    {
                        if (BhMsgBox.Question("절기는 자동 계산되는 항목입니다.\r\n수동입력이 확실합니까?")
                            != DialogResult.Yes)
                            return false;
                    }
                    if (EnableInsert(row) == false) return false;
                    errMag = sqlmanager.INSERT_ANNIVERSARY(row);
                }
                else
                {//업데이트
                    DataRow row = this.GetParamRow(this, ParamType.Update);
                    int cate = row["category"].ToIntEx();
                    if (cate == (int)CodeType_기념일구분.국가공휴일)
                    {
                        if (BhMsgBox.Question("국가공휴일은 자동 계산되는 항목입니다.\r\n수동입력이 확실합니까?")
                            != DialogResult.Yes)
                            return false;
                    }
                    else if (cate == (int)CodeType_기념일구분.절기)
                    {
                        if (BhMsgBox.Question("절기는 자동 계산되는 항목입니다.\r\n수동입력이 확실합니까?")
                            != DialogResult.Yes)
                            return false;
                    }
                    errMag = sqlmanager.UPDATE_ANNIVERSARY(row);
                }
                base.OnSaveData(this, isSave, isRefresh);
                if (string.IsNullOrEmpty(errMag) == false)
                    throw new Exception(errMag);
                return true;
            }
            catch (Exception ex)
            {
                isSave = false;
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static bool EnableInsert(DataRow row)
        {
            string errMsg = "";

            if (string.IsNullOrEmpty(errMsg) == false)
            {
                BhMsgBox.Error(errMsg);
                return false;
            }
            return true;
        }
        #endregion

        #region 기타이벤트
        private void pdpdateType_ValueChanged(object sender, EventArgs e)
        {
            int val = pdpdateType.EditValue.ToIntEx();
            switch(val)
            {
                case (int)CodeType_날짜구분.양력: rbdateType.SelectedIndex = 0; break;
                case (int)CodeType_날짜구분.음력: rbdateType.SelectedIndex = 1; break;
            }
        }

        private void rbdateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rbdateType.SelectedIndex)
            {
                case 0: pdpdateType.EditValue = (int)CodeType_날짜구분.양력; break;
                case 1: pdpdateType.EditValue = (int)CodeType_날짜구분.음력; break;
                default: pdpdateType.EditValue = -1; break;
            }
        }

        private void pdpcategory_ValueChanged(object sender, EventArgs e)
        {
            int val = pdpcategory.EditValue.ToIntEx();
            switch (val)
            {
                case (int)CodeType_기념일구분.국가공휴일: rbcategory.SelectedIndex = 0; break;
                case (int)CodeType_기념일구분.생일: rbcategory.SelectedIndex = 1; break;
                case (int)CodeType_기념일구분.기념일: rbcategory.SelectedIndex = 2; break;
                case (int)CodeType_기념일구분.일정: rbcategory.SelectedIndex = 3; break;
                case (int)CodeType_기념일구분.절기: rbcategory.SelectedIndex = 4; break;
            }
        }

        private void rbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rbcategory.SelectedIndex)
            {
                case 0: pdpcategory.EditValue = (int)CodeType_기념일구분.국가공휴일; break;
                case 1: pdpcategory.EditValue = (int)CodeType_기념일구분.생일; break;
                case 2: pdpcategory.EditValue = (int)CodeType_기념일구분.기념일; break;
                case 3: pdpcategory.EditValue = (int)CodeType_기념일구분.일정; break;
                case 4: pdpcategory.EditValue = (int)CodeType_기념일구분.절기; break;
            }
        }

        private void pdprepeatType_ValueChanged(object sender, EventArgs e)
        {
            int val = pdprepeatType.EditValue.ToIntEx();
            switch (val)
            {
                case (int)CodeType_반복구분.년반복: rbrepeatType.SelectedIndex = 0; break;
                case (int)CodeType_반복구분.월반복: rbrepeatType.SelectedIndex = 1; break;
                case (int)CodeType_반복구분.주반복: rbrepeatType.SelectedIndex = 2; break;
                case (int)CodeType_반복구분.주중반복: rbrepeatType.SelectedIndex = 3; break;
                case (int)CodeType_반복구분.주말반복: rbrepeatType.SelectedIndex = 4; break;
                case (int)CodeType_반복구분.일반복: rbrepeatType.SelectedIndex = 5; break;
                case (int)CodeType_반복구분.반복없음: rbrepeatType.SelectedIndex = 6; break;
            }
        }

        private void rbrepeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rbrepeatType.SelectedIndex)
            {
                case 0: pdprepeatType.EditValue = (int)CodeType_반복구분.년반복; break;
                case 1: pdprepeatType.EditValue = (int)CodeType_반복구분.월반복; break;
                case 2: pdprepeatType.EditValue = (int)CodeType_반복구분.주반복; break;
                case 3: pdprepeatType.EditValue = (int)CodeType_반복구분.주중반복; break;
                case 4: pdprepeatType.EditValue = (int)CodeType_반복구분.주말반복; break;
                case 5: pdprepeatType.EditValue = (int)CodeType_반복구분.일반복; break;
                case 6: pdprepeatType.EditValue = (int)CodeType_반복구분.반복없음; break;
            }
        }
        #endregion

        #region 버튼이벤트

        protected override void OnContinueBtnClick()
        {
            if (OnSaveData())
            {
                this.ResetControl(pdpname);
                rbdateType.SelectedIndex = rbcategory.SelectedIndex = rbrepeatType.SelectedIndex = -1;
            }
        }

        protected override void OnSaveBtnClick()
        {
            if (OnSaveData())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        protected override bool OnCloseBtnClick()
        {
            if (isSaveAndRefesh)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            return true;
        }

        #endregion

        #region 사용자함수
        private void EventCoupling()
        {
            rbcategory.SelectedIndexChanged += new System.EventHandler(rbcategory_SelectedIndexChanged);
            rbrepeatType.SelectedIndexChanged += new System.EventHandler(rbrepeatType_SelectedIndexChanged);
            rbdateType.SelectedIndexChanged += new System.EventHandler(rbdateType_SelectedIndexChanged);
        }
        #endregion

        private void btnColor1_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    var cos = cd.Color.R.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.B.ToString("X2");
                }
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    var cos = cd.Color.R.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.B.ToString("X2");
                }
            }
        } 

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            if(chkColor.Checked)
            {

            }
            else
            {
                pdphexColorCode.Text = "";
            }
            btnColor1.Enabled = btnColor2.Enabled = chkColor.Checked;
        }

        private void pdphexColorCode_TextChanged(object sender, EventArgs e)
        {
            Color dayColor = Color.LightGray;
            Color contentColor = Color.LightGray;
            if (pdphexColorCode.Text.Length == 12)
            {
                string dc = pdphexColorCode.Text.Substring(0, 6);
                string cc = pdphexColorCode.Text.Substring(6, 6);
                ColorConverter coc = new ColorConverter();
                dayColor = (Color)coc.ConvertFromString("#" + dc);
                contentColor = (Color)coc.ConvertFromString("#" + cc); 
            } 
            lbColorDay.BackColor = dayColor;
            lbColorContent.BackColor = contentColor;

        }
    }
}
