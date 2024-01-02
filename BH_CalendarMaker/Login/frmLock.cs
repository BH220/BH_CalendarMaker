using BH_CalendarMaker.Data;
using BH_CalendarMaker.Interface.Tables;
using BH_Core;
using BH_Core.Forms;
using BH_Core.SessionInfo;
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

namespace BH_CalendarMaker.Login
{
    public partial class frmLock : BhDialog
    {
        public delegate void ShowMainFormEventHandler(object sender, bool isShow);
        public event ShowMainFormEventHandler ShowMainFormEvent;

        public frmLock()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtId.Text = SessionHelper.Instance.UserInfo.UserId;
            txtPw.Focus();
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BHB_User bhb_user = null;
            using (var db = new BH_CalendarMakerContext())
            {
                bhb_user = db.BHB_Users.FirstOrDefault(x => x.id == txtId.Text && x.pw == txtPw.Text);
            }
            if (bhb_user != null)
            {
                if (ShowMainFormEvent != null) ShowMainFormEvent(this, true);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                BhMsgBox.Error("비밀번호가 일치하지 않습니다.");
                txtPw.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Common.ApplicationExitFlag = false;
            Close();
        }
    }
}
