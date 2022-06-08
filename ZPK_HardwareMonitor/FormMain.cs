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
    public partial class FormMain : Form
    {
        private PrefMonCollector PrefMonData;
        private PcInfo PcInfo;
        private Int32 i = 0;

        private List<double> cpuHistory = new List<double>();

        public FormMain()
        {
            InitializeComponent();
            PrefMonData = new PrefMonCollector();
            PrefMonData.SetUpdateInterval(500);
            PrefMonData.StartDataCollecting();
            PrefMonData.SetCpuTemparaturePrecision(0);
            PrefMonData.SetCpuTemparaturePrecision(1);
            PcInfo = new PcInfo();


            // CPU
            CpuNameLabel = PcInfo.GetCpuName();

            GraphCPUUsage.SetPointColor(Color.DodgerBlue);
            GraphCPUUsage.SetBackgroundColor(Color.White);
            GraphCPUUsage.SetBorderColor(Color.Black);

            GraphCPUTemp.SetPointColor(Color.Green);
            GraphCPUTemp.SetBackgroundColor(Color.White);
            GraphCPUTemp.SetBorderColor(Color.Black);

            // RAM
            ManufacturerValueLabel = PcInfo.GetManufacturer();
            ModelValueLabel = PcInfo.GetModel();
            PcInfo.SetDisplayedRamUnits("MB");
            TotalMemoryValueLabel = PcInfo.GetRamTotalMemory() + " MB";

            PcInfo.SetDisplayedRamUnits("GB");
            MaxRamLabel = PcInfo.GetRamTotalMemory().ToString();

            GraphRAM.SetPointColor(Color.Purple);
            GraphRAM.SetBackgroundColor(Color.White);
            GraphRAM.SetBorderColor(Color.Black);
            PcInfo.SetDisplayedRamUnits("MB");

            // GPU
            IntegratedGpuTextBox = PcInfo.GetMainGpuName();
            DedicatedGpuTextBox = PcInfo.GetSecondGpuName();
        }

        private void timerUptimeTick(object sender, EventArgs e)
        {
            CpuUsageTextBox = PrefMonData.GetCurrentCpuUsage(2).ToString();
            CpuTempTextBox = PrefMonData.GetCurrentCpuTemp(1).ToString();

            PcInfo.SetDisplayedRamUnits("MB");
            AvaiableRamTextBox = PrefMonData.GetCurrentRamFreeMem().ToString();

            GraphCPUUsage.DrawGraph(PrefMonData.GetCpuUsageHistory(), "percentage");
            GraphCPUTemp.DrawGraph(PrefMonData.GetCpuTempHistory(), "number", 100);
            GraphRAM.DrawGraph(PrefMonData.GetRamFreeMemHistory(), "number", PcInfo.GetRamTotalMemory());


            TimerTextBox = i.ToString(); i++;
        }

        private String TimerTextBox {
            get
            {
                return textBoxTimer.Text;
            }
            set
            {
                textBoxTimer.Text = value;
            }
        }

        private String CpuUsageTextBox
        {
            get
            {
                return textBoxCPUUsage.Text;
            }
            set
            {
                textBoxCPUUsage.Text = value + "%";
            }
        }

        private String AvaiableRamTextBox
        {
            get
            {
                return textBoxAvaiableRAM.Text;
            }
            set
            {
                textBoxAvaiableRAM.Text = value + " MB";
            }
        }

        private String CpuTempTextBox
        {
            get
            {
                return textBoxCPUTemp.Text;
            }
            set
            {
                textBoxCPUTemp.Text = value + " °C";
            }
        }
        
        private String CpuNameLabel
        {
            get
            {
                return labelCpuName.Text;
            }
            set
            {
                labelCpuName.Text = value;
            }
        }

        private String ManufacturerValueLabel
        {
            get
            {
                return labelManufacturerValue.Text;
            }
            set
            {
                labelManufacturerValue.Text = value;
            }
        }

        private String ModelValueLabel
        {
            get
            {
                return labelModelValue.Text;
            }
            set
            {
                labelModelValue.Text = value;
            }
        }

        private String TotalMemoryValueLabel
        {
            get
            {
                return labelTotalMemoryValue.Text;
            }
            set
            {
                labelTotalMemoryValue.Text = value;
            }
        }

        private String IntegratedGpuTextBox
        {
            get
            {
                return integratedGpu.Text;
            }
            set
            {
                integratedGpu.Text = value;
            }
        }

        private String DedicatedGpuTextBox
        {
            get
            {
                return dedicatedGpu.Text;
            }
            set
            {
                dedicatedGpu.Text = value;
            }
        }

        public String WindowTitle
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        public String GroupBoxCpuLabel
        {
            get
            {
                return groupBoxCpu.Text;
            }
            set
            {
                groupBoxCpu.Text = value;
            }
        }

        public String GroupBoxRamLabel
        {
            get
            {
                return groupBoxRam.Text;
            }
            set
            {
                groupBoxRam.Text = value;
            }
        }

        public String GroupBoxGpuLabel
        {
            get
            {
                return groupBoxGpu.Text;
            }
            set
            {
                groupBoxGpu.Text = value;
            }
        }

        public String CpuUsageLabel
        {
            get
            {
                return labelCpuUsage.Text;
            }
            set
            {
                labelCpuUsage.Text = value;
            }
        }

        public String CpuTemperatureLabel
        {
            get
            {
                return labelCpuTemp.Text;
            }
            set
            {
                labelCpuTemp.Text = value;
            }
        }

        public String AvaiableRamLabel
        {
            get
            {
                return labelAvaiableRam.Text;
            }
            set
            {
                labelAvaiableRam.Text = value;
            }
        }

        public String IntegratedGpuLabel
        {
            get
            {
                return labelIntegratedGpu.Text;
            }
            set
            {
                labelIntegratedGpu.Text = value;
            }
        }

        public String DedicatedGpuLabel
        {
            get
            {
                return labelDedicatedGpu.Text;
            }
            set
            {
                labelDedicatedGpu.Text = value;
            }
        }

        public String ManufacturerLabel
        {
            get
            {
                return labelManufacturer.Text;
            }
            set
            {
                labelManufacturer.Text = value;
            }
        }

        public String ModelLabel
        {
            get
            {
                return labelModel.Text;
            }
            set
            {
                labelModel.Text = value;
            }
        }

        public String TotalLabel
        {
            get
            {
                return labelTotal.Text;
            }
            set
            {
                labelTotal.Text = value;
            }
        }

        public String MaxCpuUsageLabel
        {
            get
            {
                return labelMaxCpuUsage.Text;
            }
            set
            {
                labelMaxCpuUsage.Text = value + "%";
            }
        }

        public String MinCpuUsageLabel
        {
            get
            {
                return labelMinCpuUsage.Text;
            }
            set
            {
                labelMinCpuUsage.Text = value + "%";
            }
        }

        public String MaxCpuTempLabel
        {
            get
            {
                return labelMaxTemp.Text;
            }
            set
            {
                labelMaxTemp.Text = value + " °C";
            }
        }

        public String MinCpuTempLabel
        {
            get
            {
                return labelMinTemp.Text;
            }
            set
            {
                labelMinTemp.Text = value + " °C";
            }
        }

        public String MaxRamLabel
        {
            get
            {
                return labelMaxRam.Text;
            }
            set
            {
                labelMaxRam.Text = value + " GB";
            }
        }

        public String MinRamLabel
        {
            get
            {
                return labelMinRam.Text;
            }
            set
            {
                labelMinRam.Text = value + " GB";
            }
        }

        public String UptimeLabel
        {
            get
            {
                return labelUptime.Text;
            }
            set
            {
                labelUptime.Text = value;
            }
        }
    }
}
