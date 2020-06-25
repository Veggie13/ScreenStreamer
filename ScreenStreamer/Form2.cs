using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenStreamer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int Port
        {
            get { return (int)_spnPort.Value; }
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
