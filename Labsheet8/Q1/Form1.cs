using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbrHours.Value=DateTime.Now.Hour;
            pbrMin.Value=DateTime.Now.Hour;
            pbrSec.Value=DateTime.Now.Second;
        }
    }
}
