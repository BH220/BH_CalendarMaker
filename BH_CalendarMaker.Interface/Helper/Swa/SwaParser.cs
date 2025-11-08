using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Helper.Swa
{
    public static class SwaParser
    {
        public static string ToSWA(this double o)
        {
            int val = 0;
            if (o != null)
            {
                int.TryParse(o.ToString(), out val);
            }
            string result = "";
            switch(val % 3)
            {
                case 0: result = "S"; break;
                case 1: result = "W"; break;
                case 2: result = "A"; break;
            }
            return result;
        }
    }
}
