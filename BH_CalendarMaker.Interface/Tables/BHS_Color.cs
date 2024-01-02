using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BH_CalendarMaker.Interface.Tables
{
    [Table("BHS_Color")]
    public class BHS_Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int seq { get; set; }

        public int category { get; set; }
        public string color { get; set; }
        public string createBy { get; set; }
        public DateTime createAt { get; set; }
        public string updateBy { get; set; }
        public DateTime? updateAt { get; set; }
    }
}