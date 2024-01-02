using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BH_CalendarMaker.Interface.Tables
{
    [Table("BHR_Anniversary")]
    public class BHR_Anniversary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int seq { get; set; }

        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int repeatType { get; set; }
        public string contents { get; set; }
        public int category { get; set; }
        public int dateType { get; set; }
        public int enable { get; set; }
        public string createBy { get; set; }
        public DateTime createAt { get; set; }
        public string updateBy { get; set; }
        public DateTime? updateAt { get; set; }
        public string deleteBy { get; set; }
        public DateTime? deleteAt { get; set; }
        public string hexDayColorCode { get; set; }
        public string hexContentColorCode { get; set; }
    }
}