using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libCPUInfo;

namespace ZPK_HardwareMonitor
{
    public partial class Form1 : Form
    {
        cpuinfo Info;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            Info = new cpuinfo();
            Info.updateCpuTemp();

            List<Temperature> tempki = Info.returnCpuTemp();

            textBoxCPUUsage.Text = tempki[0].CurrentValue.ToString();
            textBoxCPUTemp.Text = tempki[0].InstanceName;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Info.updateCpuUsageAvg(timer1.Interval);
            textBoxCPUUsage.Text = Info.getCpuAvgUsage().ToString() + "%";

            textBoxAvaiableRAM.Text = Info.getAvailableRAM() + " MB";

            Info.updateCpuTemp();
            List<Temperature> tempki = Info.returnCpuTemp();
            textBoxCPUTemp.Text = tempki[0].CurrentValue.ToString();
            textBoxCPUTempName.Text = tempki[0].InstanceName;

            textBoxTimer.Text = i.ToString();
            i++;

            //textBox1.Text = performanceCounter1.NextValue().ToString();
           // textBox2.Text = performanceCounter2.NextValue().ToString();
        }
    }
}
