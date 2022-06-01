using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libPrefMonCollector;
using libPCInfo;

namespace ZPK_HardwareMonitor
{
    public partial class Form1 : Form
    {
        PrefMonCollector PrefMonData;
        PcInfo PcInfo;
        int i = 0;

        List<double> cpuHistory = new List<double>();

        public Form1()
        {
            InitializeComponent();
            PrefMonData = new PrefMonCollector();
            PcInfo = new PcInfo();

            labelCpuName.Text = PcInfo.getCpuName();

            labelManufacturer.Text = PcInfo.getManufacturer();
            labelModel.Text = PcInfo.getModel();
            labelTotalMem.Text = PcInfo.getRamTotalMemMB().ToString() + " MB";

            labelMaxRamGb.Text = Math.Round(PcInfo.getRamTotalMemMB() / 1024f) + " GB";

            integratedGpu.Text = PcInfo.getMainGpuName();
            dedicatedGpu.Text = PcInfo.getSecondGpuName();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxCPUUsage.Text = Math.Round(PrefMonData.getCurrentCpuUsage(2), 2) + "%";

            textBoxCPUTemp.Text = PrefMonData.getCurrentCpuTemp(2) + " °C";

            textBoxAvaiableRAM.Text = PrefMonData.getCurrentRamFreeMem() + " MB";


            graph1.drawGraph(PrefMonData.getCpuUsageHistory(), Color.White, Color.Black, Color.DodgerBlue, "usage");

            graph2.drawGraph(PrefMonData.getCpuTempHistory(), Color.White, Color.Black, Color.DarkRed, "temp");

            graph3.drawGraph(PrefMonData.getRamFreeMemHistory(), Color.White, Color.Black, Color.Purple, "ram", PcInfo.getRamTotalMemMB());

            textBoxTimer.Text = i.ToString();
            i++;
        }
    }
}
