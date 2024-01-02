using BH_CalendarMaker.Interface.Helper.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Model
{
    public class AnniversaryModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int repeatType { get; set; }
        public string contents { get; set; }
        public int category { get; set; }
        public int dateType { get; set; }
        public string dateEx
        {
            get
            {
                string result = "";
                if (string.IsNullOrEmpty(date) == false && date.Length >= 8)
                    result = date.Substring(4, 2) + "-" + date.Substring(6, 2);
                return result;
            }
        }
        public string repeatTypeEx
        {
            get
            { 
                string result = "";
                switch(repeatType)
                {
                    case (int)CodeType_반복구분.년반복: result = "년"; break;
                    case (int)CodeType_반복구분.월반복: result = "월"; break;
                    case (int)CodeType_반복구분.주반복: result = "주"; break;
                    case (int)CodeType_반복구분.일반복: result = "일"; break;
                    case (int)CodeType_반복구분.주중반복: result = "주중"; break;
                    case (int)CodeType_반복구분.주말반복: result = "주말"; break;
                    default: result = ""; break;
                }
                return result;
            }
        }
        public string categoryEx
        {
            get
            {
                string result = "";
                switch (category)
                {
                    case (int)CodeType_기념일구분.국가공휴일: result = "국가공휴일"; break;
                    case (int)CodeType_기념일구분.절기: result = "절기"; break;
                    case (int)CodeType_기념일구분.생일: result = "생일"; break;
                    case (int)CodeType_기념일구분.기념일: result = "기념일"; break;
                    default: result = ""; break;
                }
                return result;
            }
        }
        public string dateTypeEx
        {
            get
            {
                string result = "";
                switch (dateType)
                {
                    case (int)CodeType_날짜구분.양력: result = "양력";break;
                    case (int)CodeType_날짜구분.음력: result = "음력"; break;
                    default: result = ""; break;
                }
                return result;
            }
        }
        public DateTime Anniversary { get; set; }
        private CodeType_반복구분 _repeatType = CodeType_반복구분.None;
        public CodeType_반복구분 RepeatType
        {
            get { return _repeatType; }
            set
            {
                _repeatType = value;
                repeatType = (int)_repeatType;
            }
        }
        private CodeType_기념일구분 _category = CodeType_기념일구분.None;
        public CodeType_기념일구분 CategoryType
        {
            get { return _category; }
            set
            {
                _category = value;
                category = (int)_category;
            }
        }
        private CodeType_날짜구분 _dateType = CodeType_날짜구분.None;
        public CodeType_날짜구분 DateType
        {
            get { return _dateType; }
            set
            {
                _dateType = value;
                dateType = (int)_dateType;
            }
        }
    }
}
