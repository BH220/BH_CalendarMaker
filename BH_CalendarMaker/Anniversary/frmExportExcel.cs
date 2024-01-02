using BH_CalendarMaker.Interface.Helper.Anniversary;
using BH_CalendarMaker.Interface.Helper.Code;
using BH_CalendarMaker.Interface.Model;
using BH_CalendarMaker.Properties;
using BH_Core.Forms;
using BH_Core.WaitingForm;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BH_CalendarMaker.Anniversary
{
    public partial class frmExportExcel : BhDialog
    {
        string strDate = "";
        string strMoon = "";

        List<AnniversaryModel> AnniversaryList = new List<AnniversaryModel>();
        [Obsolete("디자이너 때문에 남겨둠")]
        public frmExportExcel()
        {
            InitializeComponent();
        }

        public frmExportExcel(List<AnniversaryModel> List)
        {
            InitializeComponent();
            AnniversaryList = List;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            rgExcelType.SelectedIndex = 0;
            rgExcelType.Focus();
        }

        private void btnSetYear_Click(object sender, EventArgs e)
        {
            dtStart.Value = new DateTime(dtStart.Value.Year, 1, 1);
            dtEnd.Value = new DateTime(dtStart.Value.Year, 12, 31);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "xlsx";
                sfd.Filter = "Excel File(*.xlsx)|*.xlsx";
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = sfd.FileName;
                    btnExport.Focus();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string msg = Check();
            if (string.IsNullOrEmpty(msg) == false)
            {
                BhMsgBox.Warning(msg, "필수값 확인");
                return;
            }

            DoExport();
        }

        private void DoExport()
        {
            WaitFormInfo wfi = new WaitFormInfo();
            wfi.Work = WorkType.Start;
            wfi.Title = "기념일 정보 조회";
            wfi.Content = "공공데이터API를 통해 자료를 수집중 입니다.";
            wfi.CenterScreen = false;


            List<int> years = new List<int>();
            int ys = dtStart.Value.Year;
            int ye = dtEnd.Value.Year;
            
            for(int idx = ys; idx<=ye; idx++)
            {
                int 추석 = AnniversaryList.Count(x => x.Anniversary.Year == idx && x.name.Contains("추석"));
                if (추석 == 0)
                {
                    years.Add(idx);
                }
            }
            if (years.Count > 0)
            {
                WaitHelper.ShowWait(this, wfi.Title, wfi.Content, wfi.CenterScreen);
                years.ForEach(x =>
                {
                    AnniversaryHelper helper = new AnniversaryHelper(AnniversaryList);
                    AnniversaryList = helper.GetAnniversaryList(new DateTime(x, 1, 1), new DateTime(x, 12, 31));
                });
                WaitHelper.HideWait();
            }
            string fPath = txtPath.Text;

            if (File.Exists(fPath)) File.Delete(fPath);
            if (rgExcelType.SelectedIndex == 0)
            {
                File.WriteAllBytes(fPath, Resources.A3);
                if(ExportA3(fPath))
                    Process.Start(fPath);
            }
            else
            {
                File.WriteAllBytes(fPath, Resources.A5);
                if (ExportA5(fPath))
                    Process.Start(fPath);
            }
        }
        private bool ExportA5(string excelPath)
        {
            bool result = false;
            try
            {
                Excel.Application ea = new Excel.Application();
                Excel.Workbook wb = ea.Workbooks.Open(excelPath);
                Excel.Worksheet ws = wb.Worksheets[wb.Sheets.Count];
                string celVal = "";
                DateTime sdt = new DateTime();
                for (DateTime dt = dtStart.Value; dt < dtEnd.Value; dt = dt.AddMonths(1))
                {
                    ws = wb.Worksheets[1];
                    ws.Copy(Type.Missing, wb.Sheets[wb.Sheets.Count]);
                    ws = wb.Worksheets[wb.Sheets.Count];
                    ws.Name = dt.Year.ToString() + "-" + dt.Month.ToString("00");
                    ws = wb.Sheets[wb.Sheets.Count];

                    sdt = dt.AddDays((int)dt.DayOfWeek * -1);
                    int minseo = (sdt - (new DateTime(2017, 8, 22))).Days;
                    int twins = (sdt - (new DateTime(2019, 5, 28))).Days;
                    ws.Cells[1, 2] = dt.ToString("yyyy년 MM월");
                    int week = -1;
                    for (int idx = 0; idx < 6; idx++)
                    {
                        week = week + 4;
                        for (int dw = 2; dw <= 26; dw = dw + 4)
                        {
                            Console.WriteLine(sdt.ToString("yyyy-MM-dd 처리중.."));
                            //해당 날짜
                            ws.Cells[week, dw] = sdt.Day.ToString();
                            strDate = sdt.ToString("MMdd");
                            //해당 날짜의 민서 계산
                            ws.Cells[week, dw + 1] = string.Format("{0}", minseo++);
                            //해당 날짜의 민우아 계산
                            ws.Cells[week+1, dw + 1] = string.Format("{0}", twins++);
                            //해당 날짜의 음력 계산
                            ws.Cells[week + 2, dw + 1] = 음력변환(sdt);



                            //해당 날짜의 일정 입력
                            var lstTarget = AnniversaryList.Where(x => x.Anniversary == sdt ||
                                                                 (x.DateType == CodeType_날짜구분.양력 && x.date == strDate) ||
                                                                 (x.DateType == CodeType_날짜구분.음력 && x.date == strMoon)).ToList().OrderBy(x => x.category);
                            celVal = "";
                            int celStrIdx = 1;
                            foreach (AnniversaryModel data in lstTarget)
                            {
                                celVal += data.name + Environment.NewLine;
                                ws.Cells[week + 3, dw] = celVal;
                                CodeType_기념일구분 cate = (CodeType_기념일구분)data.category;
                                switch (cate)
                                {
                                    case CodeType_기념일구분.국가공휴일:
                                    case CodeType_기념일구분.생일:
                                        ((Excel.Range)ws.Cells[week, dw]).Font.Color = Color.Red;
                                        Color textColor = Color.Red;
                                        if (cate == CodeType_기념일구분.생일)
                                            textColor = Color.Blue;
                                        ((Excel.Range)ws.Cells[week + 3, dw]).Characters[celStrIdx, data.name.Length].Font.Color = textColor;
                                        break;
                                    case CodeType_기념일구분.기념일:
                                        ((Excel.Range)ws.Cells[week + 3, dw]).Characters[celStrIdx, data.name.Length].Font.Color = Color.Blue;
                                        break;
                                    default:
                                        ((Excel.Range)ws.Cells[week + 3, dw]).Characters[celStrIdx, data.name.Length].Font.Color = Color.Black;
                                        break;
                                }

                                celStrIdx = celVal.Length + 1;
                            }

                            //해당 날짜가 해당월의 날이 아닌 경우 색상 변경
                            if (sdt.Year == dt.Year && sdt.Month == dt.Month)
                            {

                            }
                            else
                            {
                                ((Excel.Range)ws.Cells[week, dw]).Font.Color
                                = ((Excel.Range)ws.Cells[week, dw + 1]).Font.Color
                                = ((Excel.Range)ws.Cells[week + 1, dw + 1]).Font.Color
                                = ((Excel.Range)ws.Cells[week + 2, dw + 1]).Font.Color
                                = Color.LightGray;
                            }
                            sdt = sdt.AddDays(1);
                        }
                    }
                }
                ws = wb.Sheets[1];
                ws.Delete();
                wb.Save();
                ea.Quit();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }


        private bool ExportA3(string excelPath)
        {
            bool result = false;
            try
            {
                Excel.Application ea = new Excel.Application();
                Excel.Workbook wb = ea.Workbooks.Open(excelPath);
                Excel.Worksheet ws = wb.Worksheets[wb.Sheets.Count];
                string celVal = "";
                DateTime sdt = new DateTime();
                for (DateTime dt = dtStart.Value; dt < dtEnd.Value; dt = dt.AddMonths(1))
                {
                    ws = wb.Worksheets[1];
                    ws.Copy(Type.Missing, wb.Sheets[wb.Sheets.Count]);
                    ws = wb.Worksheets[wb.Sheets.Count];
                    ws.Name = dt.Year.ToString() + "-" + dt.Month.ToString("00");
                    ws = wb.Sheets[wb.Sheets.Count];

                    sdt = dt.AddDays((int)dt.DayOfWeek * -1);
                    int minseo = (sdt - (new DateTime(2017, 8, 22))).Days;
                    int twins = (sdt - (new DateTime(2019, 5, 28))).Days;
                    ws.Cells[1, 2] = dt.ToString("yyyy년 MM월");
                    int week = 1;
                    for (int idx = 0; idx < 6; idx++)
                    {
                        week = week + 3;
                        for (int dw = 2; dw <= 26; dw = dw + 4)
                        {
                            Console.WriteLine(sdt.ToString("yyyy-MM-dd 처리중.."));
                            //해당 날짜
                            ws.Cells[week, dw] = sdt.Day.ToString();
                            strDate = sdt.ToString("MMdd");
                            //해당 날짜의 민서우아 계산
                            ws.Cells[week + 1, dw] = string.Format("{0}/{1}", minseo++, twins++);
                            //해당 날짜의 음력 계산
                            ws.Cells[week + 1, dw + 1] = 음력변환(sdt);



                            //해당 날짜의 일정 입력
                            var lstTarget = AnniversaryList.Where(x => x.Anniversary == sdt ||
                                                                 (x.DateType == CodeType_날짜구분.양력 && x.date == strDate) ||
                                                                 (x.DateType == CodeType_날짜구분.음력 && x.date == strMoon)).ToList().OrderBy(x => x.category);
                            celVal = "";
                            int celStrIdx = 1;
                            foreach (AnniversaryModel data in lstTarget)
                            {
                                celVal += data.name + Environment.NewLine;
                                ws.Cells[week + 2, dw] = celVal;
                                CodeType_기념일구분 cate = (CodeType_기념일구분)data.category;
                                switch (cate)
                                {
                                    case CodeType_기념일구분.국가공휴일:
                                    case CodeType_기념일구분.생일:
                                        ((Excel.Range)ws.Cells[week, dw]).Font.Color = Color.Red;
                                        Color textColor = Color.Red;
                                        if (cate == CodeType_기념일구분.생일)
                                            textColor = Color.Blue;
                                        ((Excel.Range)ws.Cells[week + 2, dw]).Characters[celStrIdx, data.name.Length].Font.Color = textColor;
                                        break;
                                    case CodeType_기념일구분.기념일:
                                        ((Excel.Range)ws.Cells[week + 2, dw]).Characters[celStrIdx, data.name.Length].Font.Color = Color.Blue;
                                        break;
                                    default:
                                        ((Excel.Range)ws.Cells[week + 2, dw]).Characters[celStrIdx, data.name.Length].Font.Color = Color.Black;
                                        break;
                                }

                                celStrIdx = celVal.Length + 1;
                            }

                            //해당 날짜가 해당월의 날이 아닌 경우 색상 변경
                            if (sdt.Year == dt.Year && sdt.Month == dt.Month)
                            {

                            }
                            else
                            {
                                ((Excel.Range)ws.Cells[week, dw]).Font.Color
                                = ((Excel.Range)ws.Cells[week + 1, dw]).Font.Color
                                = ((Excel.Range)ws.Cells[week + 1, dw + 1]).Font.Color
                                = Color.LightGray;
                            }

                            sdt = sdt.AddDays(1);
                        }
                    }
                }
                ws = wb.Sheets[1];
                ws.Delete();
                wb.Save();
                ea.Quit();
                result = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        private string 음력변환(DateTime dt)
        {
            int n윤월;
            int n음력년, n음력월, n음력일;
            bool b윤달 = false;
            KoreanLunisolarCalendar 음력 = new KoreanLunisolarCalendar();
            n음력년 = 음력.GetYear(dt);
            n음력월 = 음력.GetMonth(dt);
            n음력일 = 음력.GetDayOfMonth(dt);
            if (음력.GetMonthsInYear(n음력년) > 12)             //1년이 12이상이면 윤달이 있음..
            {
                b윤달 = 음력.IsLeapMonth(n음력년, n음력월);     //윤월인지
                n윤월 = 음력.GetLeapMonth(n음력년);             //년도의 윤달이 몇월인지?
                if (n음력월 >= n윤월)                           //달이 윤월보다 같거나 크면 -1을 함 즉 윤8은->9 이기때문
                    n음력월--;
            }
            strMoon = n음력월.ToString("00") + n음력일.ToString("00");
            return n음력월.ToString() + "." + n음력일.ToString();
        }

        private string Check()
        {
            string msg = string.Empty;
            if (rgExcelType.SelectedIndex < 0 || rgExcelType.SelectedIndex > 1)
                msg += "- 엑셀 내보내기 선택이 되지 않았습니다." + Environment.NewLine;
            dtStart.Value = new DateTime(dtStart.Value.Year, dtStart.Value.Month, 1);
            dtEnd.Value = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, 1).AddMonths(1).AddDays(-1);
            if (dtStart.Value > dtEnd.Value)
                msg += "- 시작일은 종료일 보다 클 수 없습니다." + Environment.NewLine;
            if (string.IsNullOrEmpty(txtPath.Text))
                msg += "- 내보낼 파일 경로가 선택되지 않았습니다." + Environment.NewLine;
            return msg;
        }
    }
}
