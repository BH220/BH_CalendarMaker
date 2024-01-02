using BH_CalendarMaker.Interface.Model;
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
    public partial class ctlCalendarView : UserControl
    {
        List<ctlDay> Days = new List<ctlDay>();
        DateTime MinDate = DateTime.Now;
        DateTime MaxDate = DateTime.Now;


        List<AnniversaryModel> AnniversaryList = new List<AnniversaryModel>();

        public ctlCalendarView()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED

                return cp;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitControl();
            DefaultColorSet(); 
        }

        private void InitControl()
        {
            Days.Add(ctlDay1); Days.Add(ctlDay2); Days.Add(ctlDay3); Days.Add(ctlDay4); Days.Add(ctlDay5); Days.Add(ctlDay6); Days.Add(ctlDay7);
            Days.Add(ctlDay8); Days.Add(ctlDay9); Days.Add(ctlDay10); Days.Add(ctlDay11); Days.Add(ctlDay12); Days.Add(ctlDay13); Days.Add(ctlDay14); 
            Days.Add(ctlDay15); Days.Add(ctlDay16); Days.Add(ctlDay17); Days.Add(ctlDay18); Days.Add(ctlDay19); Days.Add(ctlDay20); Days.Add(ctlDay21); 
            Days.Add(ctlDay22); Days.Add(ctlDay23); Days.Add(ctlDay24); Days.Add(ctlDay25); Days.Add(ctlDay26); Days.Add(ctlDay27); Days.Add(ctlDay28); 
            Days.Add(ctlDay29); Days.Add(ctlDay30); Days.Add(ctlDay31); Days.Add(ctlDay32); Days.Add(ctlDay33); Days.Add(ctlDay34); Days.Add(ctlDay35); 
            Days.Add(ctlDay36); Days.Add(ctlDay37); Days.Add(ctlDay38); Days.Add(ctlDay39); Days.Add(ctlDay40); Days.Add(ctlDay41); Days.Add(ctlDay42);
        }

        private void DefaultColorSet()
        {
            ctlDay1.DayColor = ctlDay8.DayColor = ctlDay15.DayColor = ctlDay22.DayColor = ctlDay29.DayColor = ctlDay36.DayColor
            = Color.Red;
            ctlDay7.DayColor = ctlDay14.DayColor = ctlDay21.DayColor = ctlDay28.DayColor = ctlDay35.DayColor = ctlDay42.DayColor
            = Color.Blue;
        }

        public void LoadData(DateTime month, List<AnniversaryModel> anniversaryList)
        {
            AnniversaryList = anniversaryList;
            DateTime dt = new DateTime(month.Year, month.Month, 1);
            DefaultDaySettings(dt);
            
            //Sunday = 0,
            //Monday = 1,
            //Tuesday = 2,
            //Wednesday = 3,
            //Thursday = 4,
            //Friday = 5,
            //Saturday = 6
            List<ctlDay> targetGray = GetGrayDaysFront(dt);
            targetGray.ForEach(x =>
            {
                x.AllColor = Color.Gray;
            });

            Days.ForEach(x =>
            {
                x.LoadInfo(AnniversaryList);
            });
        }

        private void DefaultDaySettings(DateTime month)
        {
            Color color = Color.Red;
            Days[0].DayColor = color;
            Days.ForEach(x =>
            {
                x.AllColor = Color.Black;
            });
            for (int idx = 0; idx < 42; idx = idx + 7)
            {
                Days[idx].DayColor = Color.Red;
            }
            for (int idx = 6; idx < 42; idx = idx + 7)
            {
                Days[idx].DayColor = Color.Blue;
            }

            int firstIdx = (int)month.DayOfWeek;
            DateTime dt = month;
            for(int idx = firstIdx-1; idx>=0; idx--)
            {
                dt = dt.AddDays(-1);
                Days[idx].Day = dt;
            }
            MinDate = dt;
            int maxDate = month.AddMonths(1).AddDays(-1).Day;
            bool targetGrayEnd = false;
            for(int idx = firstIdx; idx<42; idx++)
            {
                if(targetGrayEnd)
                    Days[idx].AllColor = Color.Gray;
                Days[idx].Day = month;
                if (month.Day == maxDate)
                    targetGrayEnd = true;
                month = month.AddDays(1);
            }
            MaxDate = month.AddDays(-1);
        }

        private List<ctlDay> GetGrayDaysFront(DateTime dt)
        {
            List<ctlDay> targetGray = new List<ctlDay>();
            if (dt.DayOfWeek != DayOfWeek.Sunday) targetGray.Add(ctlDay1); else return targetGray;
            if (dt.DayOfWeek != DayOfWeek.Monday) targetGray.Add(ctlDay2); else return targetGray;
            if (dt.DayOfWeek != DayOfWeek.Tuesday) targetGray.Add(ctlDay3); else return targetGray;
            if (dt.DayOfWeek != DayOfWeek.Wednesday) targetGray.Add(ctlDay4); else return targetGray;
            if (dt.DayOfWeek != DayOfWeek.Thursday) targetGray.Add(ctlDay5); else return targetGray;
            if (dt.DayOfWeek != DayOfWeek.Friday) targetGray.Add(ctlDay6); else return targetGray;
            if (dt.DayOfWeek != DayOfWeek.Saturday) targetGray.Add(ctlDay7); else return targetGray;
            return targetGray;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

        } 

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        { 
            Rectangle r = e.CellBounds;
            using (Pen pen = new Pen(Color.Black))
            {
                // top and left lines
                e.Graphics.DrawLine(pen, r.X, r.Y, r.X + r.Width, r.Y);
                e.Graphics.DrawLine(pen, r.X, r.Y, r.X, r.Y + r.Height);
                // last row? move hor.lines 1 up!
                int cy = e.Row == tableLayoutPanel1.RowCount - 1 ? -1 : 0;
                if (cy != 0) e.Graphics.DrawLine(pen, r.X, r.Y + r.Height + cy,
                                        r.X + r.Width, r.Y + r.Height + cy);
                // last column ? move vert. lines 1 left!
                int cx = e.Column == tableLayoutPanel1.ColumnCount - 1 ? -1 : 0;
                if (cx != 0) e.Graphics.DrawLine(pen, r.X + r.Width + cx, r.Y,
                                        r.X + r.Width + cx, r.Y + r.Height);
            }

        } 
    }
}
