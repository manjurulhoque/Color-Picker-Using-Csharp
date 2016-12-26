using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenColor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(bmp);
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            g.CopyFromScreen(new Point(cursor.X, cursor.Y), new Point(0, 0), new Size(1, 1));
            Color pixel = bmp.GetPixel(0, 0);
            var c = bmp.GetPixel(0, 0);
            string color_str = string.Format("#{0:X2}{1:X2}{2:X2}", c.R, c.G, c.B);
            string html = ColorTranslator.ToHtml(Color.FromArgb(c.R, c.G, c.B));
            //label1.Text = bmp.GetPixel(0, 0).ToString();
            textBoxhtml.Text = html;
            textBoxrgb.Text = (c.R + "," + c.G + "," + c.B).ToString();
            string hex = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            textBoxhex.Text = "0x"+hex;
            pictureBox1.BackColor = pixel;

        }

        //public Color GetColorAt(Point location)
        //{
        //    Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        //    screenPixel.Dispose();
        //    using (Graphics gdest = Graphics.FromImage(screenPixel))
        //    {
        //        using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
        //        {
        //            IntPtr hSrcDC = gsrc.GetHdc();
        //            IntPtr hDC = gdest.GetHdc();
        //            int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
        //            gdest.ReleaseHdc();
        //            gsrc.ReleaseHdc();
        //        }
        //    }

        //    return screenPixel.GetPixel(0, 0);
        //}
        //[DllImport("user32.dll", SetLastError = true)]
        //public static extern IntPtr GetDesktopWindow();
        //[DllImport("user32.dll", SetLastError = true)]
        //public static extern IntPtr GetWindowDC(IntPtr window);
        //[DllImport("gdi32.dll", SetLastError = true)]
        //public static extern uint GetPixel(IntPtr dc, int x, int y);
        //[DllImport("user32.dll", SetLastError = true)]
        //public static extern int ReleaseDC(IntPtr window, IntPtr dc);
        //public static Color GetColorAt(int x, int y)
        //{
        //    IntPtr desk = GetDesktopWindow();
        //    IntPtr dc = GetWindowDC(desk);
        //    int a = (int)GetPixel(dc, x, y);
        //    ReleaseDC(desk, dc);
        //    return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCopy.Focus();
            this.ActiveControl = btnCopy;
        }

        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Point cursor = new Point();
            //GetCursorPos(ref cursor);

            //var c = GetColorAt(cursor.X, cursor.Y);
            //this.BackColor = c;
            //MessageBox.Show(c.ToString());
            //timer1.Stop();
            //if (c.R == c.G && c.G < 64 && c.B > 128)
            //{
            //    MessageBox.Show("Blue");
            //}
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxrgb.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHtmlCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxhtml.Text);
        }

        private void btnHexCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxhex.Text);
        }
    }
}
