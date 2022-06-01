using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace libPCInfo
{
    public class PcInfo
    {
        private String cpuName;
        private String gpuName1;
        private String gpuName2;
        private UInt64 ramTotalMem = 0;
        private int ramTotalMemMB = 0;

        private String manufacturer = "Unknow";
        private String partNumber = "Unknow";

        private List<String> ramBanks = new List<string>();

        public PcInfo()
        {
            var cpuWMI = new ManagementObjectSearcher("select * from Win32_Processor").
                Get().Cast<ManagementObject>().First();
            cpuName = cpuWMI["Name"].ToString();

            var ramWMI = new ManagementObjectSearcher("select * from Win32_PhysicalMemory").
                Get().Cast<ManagementObject>();

            foreach(var item in ramWMI)
            {
                ramBanks.Add(item["Capacity"].ToString());
                ramTotalMem += Convert.ToUInt64(item["Capacity"]);

                manufacturer = item["Manufacturer"].ToString();
                partNumber = item["PartNumber"].ToString();
            }

            ramTotalMemMB = Convert.ToInt32((ramTotalMem/1024)/1024);

            var gpu1WMI = new ManagementObjectSearcher("select * from Win32_VideoController").
                Get().Cast<ManagementObject>().First();
            var gpu2WMI = new ManagementObjectSearcher("select * from Win32_VideoController").
                Get().Cast<ManagementObject>().Last();
            gpuName1 = gpu1WMI["Name"].ToString();
            gpuName2 = gpu2WMI["Name"].ToString();
        }

        public String getCpuName()
        {
            return cpuName;
        }

        public int getRamTotalMemMB()
        {
            return ramTotalMemMB;
        }

        public String getModel()
        {
            return partNumber;
        }

        public String getManufacturer()
        {
            return manufacturer;
        }

        public String getMainGpuName()
        {
            return gpuName1;
        }

        public String getSecondGpuName()
        {
            return gpuName2;
        }
    }
}
