using BH_CalendarMaker.Interface.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Database
{ 
    public class BH_CalendarMakerContext : DbContext
    {
        public BH_CalendarMakerContext() : base("name=BH_CalendarMakerContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual IDbSet<BHB_CategoryCode> BHB_CategoryCodes { get; set; }
        public virtual IDbSet<BHB_Code> BHB_Codes { get; set; }
        public virtual IDbSet<BHB_User> BHB_Users { get; set; }
        public virtual IDbSet<BHR_Anniversary> BHR_Anniversaries { get; set; }
        public virtual IDbSet<BHR_AnniversaryCalendar> BHR_AnniversaryCalendars { get; set; }
        public virtual IDbSet<BHR_Calendar> BHR_Calendars { get; set; }
        public virtual IDbSet<BHR_CalendarUser> BHR_CalendarUsers { get; set; }
        public virtual IDbSet<BHS_Color> BHS_Colors { get; set; } 

    }
}
