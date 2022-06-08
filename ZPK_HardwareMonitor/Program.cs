using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using libPCInfo;
using libPrefMonCollector;

namespace ZPK_HardwareMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain App = new FormMain();
            App.WindowTitle = "Hardware Monitor";
            App.GroupBoxCpuLabel = "CPU";
            App.GroupBoxRamLabel = "RAM";
            App.GroupBoxGpuLabel = "GPU";
            App.CpuUsageLabel = "CPU Usage";
            App.CpuTemperatureLabel = "CPU Temp";
            App.AvaiableRamLabel = "Avaiable";
            App.IntegratedGpuLabel = "Integrated GPU";
            App.DedicatedGpuLabel = "Dedicated GPU";
            App.ManufacturerLabel = "Manufacturer";
            App.ModelLabel = "Model";
            App.TotalLabel = "Total";
            App.MaxCpuUsageLabel = "100";
            App.MinCpuUsageLabel = "0";
            App.MaxCpuTempLabel = "100";
            App.MinCpuTempLabel = "0";
            //App.MaxRamLabel = "8";
            App.MinRamLabel = "0";
            App.UptimeLabel = "Uptime";

            Application.Run(App);
        }
    }
}
