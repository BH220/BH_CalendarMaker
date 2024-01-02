using BH_CalendarMaker.Interface;
using BH_Core;
using BH_Core.SessionInfo; 
using BH_Library.Utils;
using System.Linq;

namespace BH_CalendarMaker.Data.Login
{
    public class BhCalendarMakerSessionManager
    {
        public static SessionModel GetSessionHelper(string userID)
        {
            SessionModel model = new SessionModel();
            BhCalendarMakerSessionManager manager = new BhCalendarMakerSessionManager();
            if (userID.ToLower() == CalendarMakerCommon.AdministratorID)
            {
                //관리자아이디로 접속했음, 정보 안채워도 알아서 코어에서 해줄꺼임
            }
            else
            {
                model.UserModel = manager.GetUserModel(userID);
                model.OptionModel = new OptionInfo();
            }

            return model;
        }

        private SessionModel sessionModel = null;
        public SessionModel SessionModel { get { return sessionModel; } }

        private UserModel GetUserModel(string userId)
        {
            UserModel model = new UserModel(); 
            using (var db = new BH_CalendarMakerContext())
            {
                var data = db.BHB_Users.FirstOrDefault(x => x.id == userId);

                model.UserId = data.id;
                model.UserName = data.name;
                model.IsAdmin = true;
                model.UserType = UserTypes.관리자;
            } 
            return model;
        }
    }
}
