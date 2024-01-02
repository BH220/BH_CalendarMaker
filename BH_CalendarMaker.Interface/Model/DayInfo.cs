using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Model
{
    /// <summary>
    /// 일자 정보
    /// </summary>
    public class DayInfo
    {
        #region 일자 - Date

        /// <summary>
        /// 일자
        /// </summary>
        public DateTime Date { get; set; }

        #endregion
        #region 휴일 여부 - IsHoliday

        /// <summary>
        /// 휴일 여부
        /// </summary>
        public string IsHoliday { get; set; }

        #endregion
        #region 일자명 - DateName

        /// <summary>
        /// 일자명
        /// </summary>
        public string DateName { get; set; }

        #endregion
    }
}
