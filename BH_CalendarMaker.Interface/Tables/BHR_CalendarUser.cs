using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BH_CalendarMaker.Interface.Tables
{
    [Table("BHR_CalendarUser")]
    public class BHR_CalendarUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int seq { get; set; }

        public int calendarId { get; set; }
        public string userId { get; set; }
        public string note { get; set; }
        public int enable { get; set; }
        public string createBy { get; set; }
        public DateTime createAt { get; set; }
        public string updateBy { get; set; }
        public DateTime? updateAt { get; set; }
        public string deleteBy { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}