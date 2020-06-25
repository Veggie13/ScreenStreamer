using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenStreamViewer
{
    public partial class Form1 : Form
    {
        string _address;
        int _port;
        Timer _timer = new Timer();
        TcpClient _client;
        Image _image = null;

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
                _client = new TcpClient();
                await _client.ConnectAsync(_address, _port);
                _timer.Enabled = true;
            }
            catch
            {
                _client = null;
                showConnectDialog();
                return;
            }
        }

        private async void _timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var stream = _client.GetStream();
                int length = 0;
                using (var reader = new StreamReader(stream, Encoding.UTF8, false, 1024, true))
                {
                    length = int.Parse(await reader.ReadLineAsync());
                }
                using (var memStream = new MemoryStream(length))
                {
                    memStream.SetLength(length);
                    if (await stream.ReadAsync(memStream.GetBuffer(), 0, length) < length)
                    {
                        return;
                    }
                    _image = Image.FromStream(memStream);
                    _imageBox.Size = _image.Size;
                    _imageBox.Image = _image;
                }
            }
            catch (Exception ex)
            {
                _timer.Enabled = false;
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                _client = null;
                showConnectDialog();
                return;
            }
        }

        private void showConnectDialog()
        {
            _timer.Enabled = false;

            var frmConnect = new Form2();
            if (frmConnect.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }

            _address = frmConnect.Address;
            _port = frmConnect.Port;
            connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showConnectDialog();
        }
    }
}
