using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_CalendarMaker.Interface.Helper.Code
{
    public enum CodeType
    {
        None = -1,
        반복구분 = 1001,
        기념일구분  = 1002,
        날짜구분    = 1003,
    }

    public enum CodeType_반복구분
    {
        None = -1,
        년반복 = 1001001,
        월반복 = 1001002,
        주반복 = 1001003,
        주중반복 = 1001004,
        주말반복 = 1001005,
        일반복 = 1001006,
        반복없음 = 1001007,
    }

    public enum CodeType_기념일구분
    {
        None = -1,
        국가공휴일 = 1002001,
        생일 = 1002002,
        기념일 = 1002003,
        일정 = 1002004,
        절기 = 1002005,
    }

    public enum CodeType_날짜구분
    {
        None = -1,
        양력 = 1003001,
        음력 = 1003002,
    }
}
