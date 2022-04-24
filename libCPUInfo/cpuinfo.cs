using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace libCPUInfo
{
    public class cpuinfo
    {
        private List<Temperature> temp = new List<Temperature>();

        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        private float cpuAvgUsage = 0.0f;
        private float cpuAvgUsageTemp = 0.0f;
        private int cpuUpdateCounter = 0;
        public cpuinfo()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        /*
        var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

        var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new {
            FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
            TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
        }).FirstOrDefault();

        if (memoryValues != null) {
            var percent = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;
        }
        */

        public float getCurrentCpuUsage()
        {
            return cpuCounter.NextValue();
        }

        public float getCpuAvgUsage()
        {
            return cpuAvgUsage;
        }

        public void updateCpuUsageAvg(int timer)
        {
            int res = timer/10;
            cpuAvgUsageTemp += getCurrentCpuUsage();
            if (cpuUpdateCounter == res)
            {
                cpuAvgUsage = cpuAvgUsageTemp / res;
                cpuAvgUsageTemp = 0.0f;
                cpuUpdateCounter = 1;
            } else
            {
                cpuUpdateCounter++;
            }
        }

        public float getAvailableRAM()
        {
            return ramCounter.NextValue();
        }

        public List<Temperature> returnCpuTemp()
        {
            return temp;
        }

        public void updateCpuTemp()
        {
            
            List<Temperature> result = new List<Temperature>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject obj in searcher.Get())
            {
                Double temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                temperature = (temperature - 2732) / 10.0;
                result.Add(new Temperature { CurrentValue = temperature, InstanceName = obj["InstanceName"].ToString() });
            }
            //result.Add(new Temperature { CurrentValue = 60, InstanceName = "first" });
            //result.Add(new Temperature { CurrentValue = 70, InstanceName = "second" });
            temp.Clear();
            temp = result;
        }
    }

    public class Temperature
    {
        public double CurrentValue { get; set; }
        public string InstanceName { get; set; }
    }
}
