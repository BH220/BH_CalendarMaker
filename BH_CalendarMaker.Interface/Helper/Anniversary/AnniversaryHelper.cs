using BH_CalendarMaker.Interface.Helper.Code;
using BH_CalendarMaker.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Helper.Anniversary
{
    public class AnniversaryHelper
    {
        List<AnniversaryModel> AnniversaryList = new List<AnniversaryModel>();

        public AnniversaryHelper(List<AnniversaryModel> list)
        {
            AnniversaryList = list;
        }

        public List<AnniversaryModel> GetAnniversaryList(DateTime dtStart, DateTime dtEnd)
        {
            
            AnniversaryModel model = null;
            string serviceKey = "yWevBZP%2FjDRdODyPDrOZVSKFQXbNIgvVlrkX%2F3S5Q2ARzoZ8i3oNZWSlybHZ4JEvZMTVzJApcOUbw%2FtYN2SaGA%3D%3D";

            #region 국경일(공휴일)을 출력한다.

            NationalHolidayHelper helper1 = new NationalHolidayHelper(serviceKey);

            List<DayInfo> dayInfoList1 = helper1.Download(dtStart, dtEnd);

            foreach (DayInfo di in dayInfoList1)
            {
                model = new AnniversaryModel();
                model.Anniversary = di.Date;
                model.CategoryType = di.IsHoliday == "Y" ? CodeType_기념일구분.국가공휴일 : CodeType_기념일구분.절기;
                model.RepeatType = CodeType_반복구분.년반복;
                model.DateType = CodeType_날짜구분.양력;
                string dtTemp = di.Date.ToString("MM.dd");
                switch (dtTemp)
                {
                    case "01.01": model.name = "신정"; break;
                    case "12.25": model.name = "크리스마스"; break;
                    default: model.name = di.DateName; break;
                }
                if (AnniversaryList.Any(x => x.Anniversary == model.Anniversary && x.contents == model.contents) == false)
                    AnniversaryList.Add(model);
                Console.WriteLine(string.Format("{0} {1} {2}", di.Date.ToString("yyyy-MM-dd"), di.IsHoliday, di.DateName));
            }

            #endregion

            #region 25절기를 출력한다.

            SeasonalDivisionHelper helper3 = new SeasonalDivisionHelper(serviceKey);

            List<DayInfo> dayInfoList3 = helper3.Download(dtStart, dtEnd);

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("24절기");
            //Console.WriteLine("----------------------------------------");

            foreach (DayInfo di in dayInfoList3)
            {
                model = new AnniversaryModel();
                model.Anniversary = di.Date;
                model.CategoryType = CodeType_기념일구분.절기;
                model.RepeatType = CodeType_반복구분.년반복;
                model.DateType = CodeType_날짜구분.양력;
                model.name = di.DateName;
                if (AnniversaryList.Any(x => x.Anniversary == model.Anniversary && x.contents == model.contents) == false)
                    AnniversaryList.Add(model);
                Console.WriteLine(string.Format("{0} {1} {2}", di.Date.ToString("yyyy-MM-dd"), di.IsHoliday, di.DateName));

                //Console.WriteLine(string.Format("{0} {1} {2}", dayInfo.Date.ToString("yyyy-MM-dd"), dayInfo.IsHoliday, dayInfo.DateName));
            }

            #endregion

            #region 잡절기를 출력한다.

            SeasonalEtcDivisionHelper helper4 = new SeasonalEtcDivisionHelper(serviceKey);

            List<DayInfo> dayInfoList4 = helper4.Download(dtStart, dtEnd);

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("24절기");
            //Console.WriteLine("----------------------------------------");

            foreach (DayInfo di in dayInfoList4)
            {
                model = new AnniversaryModel();
                model.Anniversary = di.Date;
                model.CategoryType = CodeType_기념일구분.절기;
                model.RepeatType = CodeType_반복구분.년반복;
                model.DateType = CodeType_날짜구분.양력;
                model.name = di.DateName;
                if (AnniversaryList.Any(x => x.Anniversary == model.Anniversary && x.contents == model.contents) == false)
                    AnniversaryList.Add(model);
                Console.WriteLine(string.Format("{0} {1} {2}", di.Date.ToString("yyyy-MM-dd"), di.IsHoliday, di.DateName));

                //Console.WriteLine(string.Format("{0} {1} {2}", dayInfo.Date.ToString("yyyy-MM-dd"), dayInfo.IsHoliday, dayInfo.DateName));
            }

            #endregion

            return AnniversaryList;
        }
    }
}
