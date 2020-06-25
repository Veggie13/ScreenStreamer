using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenStreamer
{
    public partial class Form1 : Form
    {
        Timer _timer = new Timer();
        bool _transparent = false;
        int _port;
        TcpListener _listener;
        TcpClient _client;

        public Form1()
        {
            InitializeComponent();

            _timer.Interval = 500;
            _timer.Tick += _timer_Tick;

        }

        private async void connect()
        {
            try
            {
                _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), _port);
                _listener.Start();
                _client = await _listener.AcceptTcpClientAsync();
                _timer.Enabled = true;
            }
            catch
            {
                _client = null;
                showServerDialog();
                return;
            }
        }

        private async void _timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Rectangle bounds = this.RectangleToScreen(ClientRectangle);
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                    }
                    var stream = _client.GetStream();
                    using (var memStream = new MemoryStream())
                    {
                        bitmap.Save(memStream, ImageFormat.Jpeg);
                        using (var writer = new StreamWriter(stream, Encoding.UTF8, 1024, true))
                        {
                            await writer.WriteLineAsync(string.Format("{0}", memStream.Length));
                        }
                        await stream.WriteAsync(memStream.ToArray(), 0, (int)memStream.Length);
                    }
                }
            }
            catch
            {
                _client = null;
                showServerDialog();
                return;
            }
        }

        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                if (_transparent)
                {
                    parms.ExStyle |= WS_EX_LAYERED | WS_EX_TRANSPARENT;
                }
                return parms;
            }
        }

        private void showServerDialog()
        {
            _timer.Enabled = false;

            var frmServer = new Form2();
            if (frmServer.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }

            _port = frmServer.Port;
            connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showServerDialog();
        }


        bool _dragging = false;
        Point mousePoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            mousePoint = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                var point = Location;
                point.Offset(e.Location.X - mousePoint.X, e.Location.Y - mousePoint.Y);
                Location = point;
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
