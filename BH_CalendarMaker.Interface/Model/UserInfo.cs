using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Model
{
    public class UserInfo
    {
        public string UserId { get; private set; }
        public string UserName { get; private set; }

        public string UserMobile { get; private set; }
        public string UserEmail { get; private set; }
        public bool IsAdmin { get; private set; }
        //public UserTypes UserType { get; private set; }

        public void SetInfoAdmin()
        {
            UserId = "bhSoftAdmin";
            UserName = "bhSoftAdmin";
            UserMobile = "010-9126-8196";
            UserEmail = "bhsoft.contact@gmail.com";
            IsAdmin = true;
            //UserType = UserTypes.관리자;
        }

        public void SetInfo(UserInfo userInfo)
        {
            SetValue(userInfo);
        }

        public void Refresh(UserInfo userInfo)
        {
            SetValue(userInfo);
        }

        private void SetValue(UserInfo userInfo)
        {
            UserName = userInfo.UserName;
            UserMobile = userInfo.UserMobile;
            UserEmail = userInfo.UserEmail;
            IsAdmin = userInfo.IsAdmin;
            UserId = userInfo.UserId;
            //UserType = userModel.UserType;
        }

        public void SetInfo(string userId, string userName, string userMobile, string userEmail, bool isAdmin)
        {
            UserId = userId;
            UserName = userName;
            UserMobile = userMobile;
            UserEmail = userEmail;
            IsAdmin = isAdmin;
        }
    }
}
