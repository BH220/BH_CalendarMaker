using System;
using System.Drawing;
using System.Windows.Forms;

namespace BH_CalendarMaker
{
    public partial class frmAbout : Form
    {
        string text, copyright1, copyright2 = "All Rights Reserved";
        string mail = "bhsoft.contact@gmail.com";
        string productSN = string.Empty;
        Font font1, font2;
        double dOpacity;
        //Bitmap backgroundBitmap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel llbDevExpress;

        public static void Show(string title)
        {
            frmAbout box = new frmAbout(title);
            box.ShowDialog();
        }
        public frmAbout(string s)
        {
            InitializeComponent();

            //backgroundBitmap = Properties.Resources.about;

            this.productSN = String.Format("Version : {0}", Application.ProductVersion);
            text = s;
            this.dOpacity = 0.15;
            timer1.Interval = 100;
            int year = DateTime.Now.Year;
            if (year < 2012) year = 2012;
            copyright1 = "Copyright  2016-" + year.ToString() + " BH";
            //			backgroundBitmap = Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.Utils.about.jpg")) as Bitmap;

            //backgroundBitmap.MakeTransparent();
            //ClientSize = backgroundBitmap.Size;
            llbDevExpress.Text = mail;
            llbDevExpress.Width = Width;

            llbDevExpress.Location = new Point(0, 154);
            llbDevExpress.LinkBehavior = LinkBehavior.NeverUnderline;
            try
            {
                llbDevExpress.Font = new Font("굴림", 9);
                font1 = new Font("굴림", 9);
                font2 = new Font("굴림", 8);
            }
            catch { }
            this.BackgroundImage = global::BH_CalendarMaker.Properties.Resources.about;
        }
        bool IsRegionSupported
        {
            get
            {
                return (System.Environment.OSVersion.Version.Major > 5 || (System.Environment.OSVersion.Version.Major == 5 && System.Environment.OSVersion.Version.Minor > 0));
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (IsRegionSupported)
                    cp.ClassStyle |= 0x20000;
                return cp;
            }
        }

        private void frmAbout_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //e.Graphics.DrawImage(backgroundBitmap, 0, 0);
            if (font1 == null) return;

            using (StringFormat stf = new StringFormat())
            {
                stf.Alignment = StringAlignment.Center;
                stf.Trimming = StringTrimming.EllipsisCharacter;
                SolidBrush brush1 = new SolidBrush(Color.FromArgb(190, 190, 190));
                SolidBrush brush2 = new SolidBrush(Color.FromArgb(255, 255, 255));
                e.Graphics.DrawString(copyright1, font2, brush1, new Rectangle(0, 175, Width, 15), stf);
                e.Graphics.DrawString(copyright2, font2, brush1, new Rectangle(0, 185, Width, 15), stf);
                e.Graphics.DrawString(text, font1, brush2, new Rectangle(10, 90, Width - 20, 30), stf);
                e.Graphics.DrawString(productSN, font1, brush2, new Rectangle(10, 110, Width - 20, 30), stf);
            }
        }
        protected void llbDevExpress_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + mail);
        }

        protected void llbDevExpress_MouseLeave(object sender, System.EventArgs e)
        {
            llbDevExpress.LinkColor = Color.FromArgb(171, 222, 255);
        }
        protected void llbDevExpress_MouseEnter(object sender, System.EventArgs e)
        {
            llbDevExpress.LinkColor = Color.FromArgb(49, 118, 214);
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (Opacity < 1)
                Opacity += dOpacity;
            else
                timer1.Enabled = false;
        }
        private void frmAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }

        bool blnMoving = false;
        int MouseDownX, MouseDownY;
        Rectangle moveFormRectangle = new Rectangle(120, 45, 35, 35);

        private void frmAbout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            //if (!moveFormRectangle.Contains(e.X, e.Y)) Close();
            blnMoving = true;
            MouseDownX = e.X;
            MouseDownY = e.Y;
        }

        private void frmAbout_MouseMove(object sender, MouseEventArgs e)
        {
            if (blnMoving)
                this.Location = new Point(
                    this.Location.X + (e.X - MouseDownX),
                    this.Location.Y + (e.Y - MouseDownY));
        }

        private void frmAbout_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                blnMoving = false;
        }

        private void frmAbout_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
