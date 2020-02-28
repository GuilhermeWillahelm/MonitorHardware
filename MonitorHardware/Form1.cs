using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorHardware
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRam.NextValue();
            metroProgressBarCpu.Value = (int)fcpu;
            metroProgressBarRam.Value = (int)fram;
            lblCpu.Text = string.Format("{0:0.00}%", fcpu);
            lblRam.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
