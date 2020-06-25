using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenStreamViewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Address
        {
            get { return _txtAddress.Text; }
        }

        public int Port
        {
            get { return (int)_spnPort.Value; }
        }

        private void _btnConnect_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
