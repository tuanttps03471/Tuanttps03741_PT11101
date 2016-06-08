using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuanttps03741_PT11101
{
    public partial class Form1 : Form
    {
        public object OpenFileDialog1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtthem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDig = new OpenFileDialog();
            OpenFileDialog1.Filter = OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
