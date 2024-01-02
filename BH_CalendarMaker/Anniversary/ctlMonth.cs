using BH_CalendarMaker.Interface.Model;
using BH_Library.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_CalendarMaker.Anniversary
{
    public partial class ctlMonth : UserControl
    {
        public ctlMonth()
        {
            InitializeComponent();
        }

        public void OnSetData()
        {
            List<CalendarModel> lst = new List<CalendarModel>();
            for(int idx=1; idx<=42;idx++)
            {
                lst.Add(new CalendarModel());
            }
            bhGrid1.SetDataSource(lst.ToTable());
        }
    }
}
