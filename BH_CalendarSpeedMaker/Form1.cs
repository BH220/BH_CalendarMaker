using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_CalendarSpeedMaker
{
    public partial class Form1 : Form
    {
        int dy = 2022;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadA3(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadA5(ofd.FileName);
                }
            }
        }

        private void LoadA3(string filePath)
        {
            spreadsheetControl1.LoadDocument(filePath);

            DateTime dt = new DateTime(dy, 1, 1);
            DateTime ms = new DateTime(2017, 8, 22);
            DateTime mwa = new DateTime(2019, 5, 28);


            int a = (dt - ms).Days + 1;


            for (int idx = 0; idx < 12; idx++)
            {
                Worksheet sheet = this.spreadsheetControl1.Document.Worksheets[idx];
                sheet.Cells[0, 1].Value = string.Format("{0}년 {1}월", dy, idx + 1);
                //날계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 3; r <= 18; r = r + 3)
                {
                    for (int c = 1; c <= 25; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = dt.Day;
                        dt = dt.AddDays(1);
                    }
                }

                //음력계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 4; r <= 19; r = r + 3)
                {
                    for (int c = 2; c <= 26; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = ToLunarDate(dt).ToString("M.d");
                        //sheet.Cells[r, c].Value = "2.30";
                        dt = dt.AddDays(1);
                    }
                }

                //애들날계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 4; r <= 19; r = r + 3)
                {
                    for (int c = 1; c <= 25; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = string.Format("{0}/{1}", (dt - ms).Days + 1, (dt - mwa).Days + 1);
                        dt = dt.AddDays(1);
                    }
                }
            }

            spreadsheetControl1.SaveDocument();
        }

        private DateTime GetStartDate(DateTime dt)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday: dt = dt.AddDays(-7); break;
                case DayOfWeek.Monday: dt = dt.AddDays(-1); break;
                case DayOfWeek.Tuesday: dt = dt.AddDays(-2); break;
                case DayOfWeek.Wednesday: dt = dt.AddDays(-3); break;
                case DayOfWeek.Thursday: dt = dt.AddDays(-4); break;
                case DayOfWeek.Friday: dt = dt.AddDays(-5); break;
                case DayOfWeek.Saturday: dt = dt.AddDays(-6); break;
            }
            return dt;
        }

        private void LoadA5(string filePath)
        {
            spreadsheetControl1.LoadDocument(filePath);

            DateTime dt = new DateTime(dy, 1, 1);
            DateTime ms = new DateTime(2017, 8, 22);
            DateTime mwa = new DateTime(2019, 5, 28);


            int a = (dt - ms).Days + 1;


            for (int idx = 0; idx < 12; idx++)
            {
                Worksheet sheet = this.spreadsheetControl1.Document.Worksheets[idx];
                sheet.Cells[0, 1].Value = string.Format("{0}년 {1}월", dy, idx + 1);
                //날계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 2; r <= 22; r = r + 4)
                {
                    for (int c = 1; c <= 25; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = dt.Day;
                        dt = dt.AddDays(1);
                    }
                }

                //음력계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 4; r <= 24; r = r + 4)
                {
                    for (int c = 2; c <= 26; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = ToLunarDate(dt).ToString("M.d");
                        //sheet.Cells[r, c].Value = "2.30";
                        dt = dt.AddDays(1);
                    }
                }

                //민서날계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 2; r <= 22; r = r + 4)
                {
                    for (int c = 2; c <= 26; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = ((dt - ms).Days + 1).ToString();
                        dt = dt.AddDays(1);
                    }
                }

                //민우아날계산
                dt = GetStartDate(new DateTime(dy, idx + 1, 1));
                for (int r = 3; r <= 23; r = r + 4)
                {
                    for (int c = 2; c <= 26; c = c + 4)
                    {
                        sheet.Cells[r, c].Value = ((dt - mwa).Days + 1).ToString();
                        dt = dt.AddDays(1);
                    }
                }
            }

            spreadsheetControl1.SaveDocument();
        }

        public DateTime ToLunarDate(DateTime dt)
        {
            int n윤월;
            int n음력년, n음력월, n음력일;
            bool b윤달 = false;
            System.Globalization.KoreanLunisolarCalendar 음력 =
            new System.Globalization.KoreanLunisolarCalendar();

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
            DateTime ndt = DateTime.Now;
            try
            {
                ndt = new DateTime(n음력년, n음력월, n음력일);
            }
            catch(Exception ex)
            {

            }

            return ndt;
        }
    }
}
