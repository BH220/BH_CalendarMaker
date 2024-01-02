using BH_CalendarMaker.Data;
using BH_CalendarMaker.Interface.Helper.Code;
using BH_CalendarMaker.Interface.Model;
using BH_CalendarMaker.Interface.Tables;
using BH_Core.SessionInfo;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Anniversary
{
    public class SqlManager
    {
        public DataTable SELECT_ANNIVERSARY_LIST_SEARCH(CodeType_기념일구분 codeType = CodeType_기념일구분.None)
        {
            DataTable resultDt = null;
            using (var db = new BH_CalendarMakerContext())
            {
                var anTemp = from data in db.BHR_Anniversaries
                             where data.enable == 1
                             select data;
                if ( codeType !=  CodeType_기념일구분.None)
                {
                    anTemp = from data in anTemp
                             where data.category == (int)codeType
                             select data;
                }

                var anniversaries = from data in anTemp
                                    where data.enable == 1
                                    select new AnniversaryModel()
                                    {
                                        id = data.id,
                                        name = data.name,
                                        date = data.date,
                                        repeatType = data.repeatType,
                                        contents = data.contents,
                                        category = data.category,
                                        dateType = data.dateType
                                    };
                resultDt = anniversaries.OrderBy(x => x.date).ToTable();
            }
            return resultDt;
        }


        public DataTable SELECT_ANNIVERSARY_LIST(int id = -1)
        {
            DataTable resultDt = null;
            using (var db = new BH_CalendarMakerContext())
            {
                var anTemp = from data in db.BHR_Anniversaries
                             where data.enable == 1
                             select data;
                if (id > 0)
                {
                    anTemp = from data in anTemp
                             where data.id == id
                             select data;
                }
                var anniversaries = from data in anTemp
                                    where data.enable == 1
                                    select new AnniversaryModel()
                                    {
                                        id = data.id,
                                        name = data.name,
                                        date = data.date,
                                        repeatType = data.repeatType,
                                        contents = data.contents,
                                        category = data.category,
                                        dateType = data.dateType
                                    };
                resultDt = anniversaries.ToTable();
            }
            return resultDt;
        }
        
        public string INSERT_ANNIVERSARY(DataRow row)
        {
            string errMsg = string.Empty;
            BHR_Anniversary anni = new BHR_Anniversary();

            anni.id           = -1;
            anni.name         = row["name"].ToStringEx();
            anni.date         = row["date"].ToStringEx();
            anni.repeatType   = row["repeatType"].ToIntEx();
            anni.contents     = row["contents"].ToStringEx();
            anni.category     = row["category"].ToIntEx();
            anni.dateType     = row["dateType"].ToIntEx();
            anni.enable       = 1;
            anni.createBy     = SessionHelper.Instance.UserInfo.UserId;
            anni.createAt     = DateTime.Now;

            try
            {
                using (var db = new BH_CalendarMakerContext())
                {
                    var vlst = db.BHR_Anniversaries.Select(x => x.id);
                    if (vlst != null && vlst.Any())
                        anni.id = vlst.Max() + 1;
                    else
                        anni.id = 1;
                    db.BHR_Anniversaries.Add(anni);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            return errMsg;
        }

        public string UPDATE_ANNIVERSARY(DataRow row)
        {
            string errMsg = string.Empty; 
            try
            {
                using (var db = new BH_CalendarMakerContext())
                {
                    int id = row["id"].ToIntEx();
                    var anni = db.BHR_Anniversaries.FirstOrDefault(x => x.id == id);
                    anni.name = row["name"].ToStringEx();
                    anni.date = row["date"].ToStringEx();
                    anni.repeatType = row["repeatType"].ToIntEx();
                    anni.contents = row["contents"].ToStringEx();
                    anni.category = row["category"].ToIntEx();
                    anni.dateType = row["dateType"].ToIntEx();
                    anni.updateBy= SessionHelper.Instance.UserInfo.UserId;
                    anni.updateAt = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            return errMsg;
        }

        public string DELETE_ANNIVERSARY(int id)
        {
            string errMsg = string.Empty;
            try
            {
                using (var db = new BH_CalendarMakerContext())
                {
                    var anni = db.BHR_Anniversaries.FirstOrDefault(x => x.id == id);
                    if(anni != null)
                    {
                        anni.enable = 0;
                        anni.deleteAt = DateTime.Now;
                        anni.deleteBy = SessionHelper.Instance.UserInfo.UserId;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            return errMsg;
        }
    }
}
