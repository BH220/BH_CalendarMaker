using BH_CalendarMaker.Interface.Helper.Code;
using BH_CalendarMaker.Interface.Model;
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

namespace BH_CalendarMaker.Anniversary
{
    public partial class ctlDay : UserControl
    {
        DateTime Date = DateTime.Now;
        string strDate = "";
        string strMoon = "";
        public ctlDay()
        {
            InitializeComponent();
        }

        public DateTime Day
        {
            set
            {
                Date = value;
                lbDay.Text = Date.Day.ToString();
                strDate = Date.ToString("MMdd");
                DateTime minseo = new DateTime(2017, 8, 22);
                lbMinseo.Text = (Date - minseo).Days.ToString("#,#");
                DateTime twins = new DateTime(2019, 5, 28);
                lbTwins.Text = (Date - twins).Days.ToString("#,#");
                lbMoon.Text = 음력변환(Date);
            }
        }

        public void LoadInfo(List<AnniversaryModel> anniversaryList)
        {
            txtContent.Text = "";
            var lstTarget = anniversaryList.Where(x => x.Anniversary == Date ||
            (x.DateType == CodeType_날짜구분.양력 && x.date == strDate) ||
            (x.DateType == CodeType_날짜구분.음력 && x.date == strMoon)).ToList();
            
            foreach (AnniversaryModel data in lstTarget)
            {
                CodeType_기념일구분 cate = (CodeType_기념일구분)data.category;
                switch (cate)
                {
                    case CodeType_기념일구분.국가공휴일: 
                    case CodeType_기념일구분.생일:
                        if (lbDay.ForeColor != Color.Gray)
                            DayColor = Color.Red;
                        break;
                }

                if (string.IsNullOrEmpty(txtContent.Text))
                    txtContent.Text = data.name;
                else
                    txtContent.Text += Environment.NewLine + data.name;
            }
        }

        private string 음력변환(DateTime dt)
        {
            int n윤월;
            int n음력년, n음력월, n음력일;
            bool b윤달 = false;
            KoreanLunisolarCalendar 음력 =new KoreanLunisolarCalendar();
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

        public Color AllColor
        {
            set
            {
                lbDay.ForeColor = lbMinseo.ForeColor = lbTwins.ForeColor =  lbMoon.ForeColor = value;
            }
        }

        public Color DayColor
        {
            set
            {
                lbDay.ForeColor = value;
            }
        }
    }
}
