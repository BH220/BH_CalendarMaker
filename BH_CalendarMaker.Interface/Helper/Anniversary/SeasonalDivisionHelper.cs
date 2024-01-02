using BH_CalendarMaker.Interface.Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Helper.Anniversary
{
    /// <summary>
    /// 24 절기 헬퍼
    /// </summary>
    public class SeasonalDivisionHelper
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 웹 클라이언트
        /// </summary>
        private WebClient webClient = null;

        /// <summary>
        /// 서비스 키
        /// </summary>
        private string serviceKey = null;

        /// <summary>
        /// URL 포맷 문자열
        /// </summary>
        private string urlFormat = null;

        /// <summary>
        /// 일자 정보 리스트
        /// </summary>
        private List<DayInfo> dayInfoList = null;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Property
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 일자 정보 리스트 - DayInfoList

        /// <summary>
        /// 일자 정보 리스트
        /// </summary>
        public List<DayInfo> DayInfoList
        {
            get
            {
                return this.dayInfoList;
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - SeasonalDivisionHelper(serviceKey)

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="serviceKey">서비스 키</param>
        public SeasonalDivisionHelper(string serviceKey)
        {
            this.webClient = new WebClient();

            this.webClient.Encoding = Encoding.UTF8;

            this.serviceKey = serviceKey;

            this.urlFormat = "http://apis.data.go.kr/B090041/openapi/service/SpcdeInfoService/get24DivisionsInfo?serviceKey={0}&solYear={1:d4}&solMonth={2:d2}";

            this.dayInfoList = new List<DayInfo>();

        }


        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 다운로드 하기 - Download(fromYear, fromMonth, toYear, toMonth)

        /// <summary>
        /// 다운로드 하기
        /// </summary>
        /// <param name="fromYear">FROM 연도</param>
        /// <param name="fromMonth">FROM 월</param>
        /// <param name="toYear">TO 연도</param>
        /// <param name="toMonth">TO 월</param>
        /// <returns>일자 정보 리스트</returns>
        public List<DayInfo> Download(DateTime startDt, DateTime endDt)//int fromYear, int fromMonth, int toYear, int toMonth)
        {

            this.dayInfoList.Clear();

            DateTime startDate = startDt;// new DateTime(fromYear, fromMonth, 1);
            DateTime endDate = endDt;// new DateTime(toYear, toMonth, 1);
            DateTime currentDate = startDate;

            while (currentDate <= endDate)
            {
                string html = DownloadString(currentDate.Year, currentDate.Month);

                List<DayInfo> dayInfoList = GetDayInfoList(html);

                foreach (DayInfo dayInfo in dayInfoList)
                {
                    this.dayInfoList.Add(dayInfo);
                }


                currentDate = currentDate.AddMonths(1);
            }

            return this.dayInfoList;
        } 

        #endregion

        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region 문자열 다운로드 하기 - DownloadString(year, month)

        /// <summary>
        /// 문자열 다운로드 하기
        /// </summary>
        /// <param name="year">연도</param>
        /// <param name="month">월</param>
        /// <returns>문자열</returns>
        private string DownloadString(int year, int month)
        {
            string url = string.Format(this.urlFormat, this.serviceKey, year, month);

            string result = this.webClient.DownloadString(url);

            return result;
        }

        #endregion
        #region 일자/시간 구하기 - GetDateTime(source)

        /// <summary>
        /// 일자/시간 구하기
        /// </summary>
        /// <param name="source">소스 문자열</param>
        /// <returns>일자/시간</returns>
        private DateTime GetDateTime(string source)
        {
            string dateString = string.Format("{0}-{1}-{2}", source.Substring(0, 4), source.Substring(4, 2), source.Substring(6, 2));

            return DateTime.Parse(dateString);
        }

        #endregion
        #region 일자 정보 리스트 구하기 - GetDayInfoList(html)

        /// <summary>
        /// 일자 정보 리스트 구하기
        /// </summary>
        /// <param name="html">HTML 문자열</param>
        /// <returns>일자 정보 리스트</returns>
        private List<DayInfo> GetDayInfoList(string html)
        {
            List<DayInfo> targetList = new List<DayInfo>();

            if (string.IsNullOrEmpty(html))
            {
                return targetList;
            }

            HtmlDocument document = new HtmlDocument();

            document.LoadHtml(html);

            HtmlNodeCollection colleciton = document.DocumentNode.SelectNodes("/response[1]/body[1]/items[1]");

            if (colleciton != null && colleciton.Count > 0)
            {
                HtmlNode itemsNode = colleciton[0];

                foreach (HtmlNode childNode in itemsNode.ChildNodes)
                {
                    string dateKind = childNode.ChildNodes[0].InnerText;
                    string dateName = childNode.ChildNodes[1].InnerText;
                    string isHoliday = childNode.ChildNodes[2].InnerText;
                    string kst = childNode.ChildNodes[3].InnerText;
                    string date = childNode.ChildNodes[4].InnerText;
                    string sequence = childNode.ChildNodes[5].InnerText;
                    //string sunLongitude = childNode.ChildNodes[6].InnerText;

                    targetList.Add(new DayInfo { Date = GetDateTime(date), IsHoliday = isHoliday, DateName = dateName });
                }
            }

            return targetList;
        }

        #endregion
    }
}
