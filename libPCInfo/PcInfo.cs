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
        // Zdefiniowanie zmiennych prywatnych
        private String _cpuName;
        private String _gpuName1;
        private String _gpuName2;
        private UInt64 _ramTotalMemory;
        private Int32 _ramUnitsType;

        private String _manufacturer;
        private String _partNumber;

        private List<String> _ramBanks;

        // Konstruktor PcInfo
        public PcInfo()
        {
            // Inicjalizacja zmiennych prywatnych
            _ramTotalMemory = 0;
            _manufacturer = "Unknow";
            _partNumber = "Unknow";
            _ramBanks = new List<String>();
            _ramUnitsType = 0;

            String selectProcessor = "SELECT * from Win32_Processor";
            String selectPhysicalMemory = "SELECT * from Win32_PhysicalMemory";
            String selectVideoController = "SELECT * from Win32_VideoController";

            ManagementObject cpuWMI = WmiQuery(selectProcessor).First();
            _cpuName = cpuWMI["Name"].ToString();

            IEnumerable<ManagementObject> ramWMI = WmiQuery(selectPhysicalMemory);
            foreach(ManagementObject item in ramWMI)
            {
                _ramBanks.Add(item["Capacity"].ToString());
                _ramTotalMemory += Convert.ToUInt64(item["Capacity"]);

                _manufacturer = item["Manufacturer"].ToString();
                _partNumber = item["PartNumber"].ToString();
            }


            ManagementObject gpu1WMI = WmiQuery(selectVideoController).First();
            ManagementObject gpu2WMI = WmiQuery(selectVideoController).Last();


            _gpuName1 = gpu1WMI["Name"].ToString();
            _gpuName2 = gpu2WMI["Name"].ToString();
        }

        // [Funkcjonalny] Zwraca nazwę procesora
        public String GetCpuName()
        {
            return _cpuName;
        }

        // [Funkcjonalny] Zwraca całkowitą ilość zainstalowanego RAM-u
        public UInt64 GetRamTotalMemory()
        {
            switch (_ramUnitsType)
            {
                case 0:
                    return _ramTotalMemory;
                case 1:
                    return _ramTotalMemory / 1024;
                case 2:
                    return _ramTotalMemory / 1048576;
                case 3:
                    return _ramTotalMemory / 1073741824;
                case 4:
                    return _ramTotalMemory / 1099511627776;
                default:
                    return _ramTotalMemory;
            }
        }

        // [Niefunkcjonalny] Ustawia w jakich jednostkach będzia zwracana ilość pamięci RAM z funkcji GetRamTotalMemory()
        public void SetDisplayedRamUnits(String unit)
        {
            if (String.Equals(unit, "b", StringComparison.OrdinalIgnoreCase) 
                || String.Equals(unit, "byte", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "bytes", StringComparison.OrdinalIgnoreCase))
            {
                _ramUnitsType = 0;
            } else if (String.Equals(unit, "kb", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "kilobyte", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "kilobytes", StringComparison.OrdinalIgnoreCase))
            {
                _ramUnitsType = 1;
            }
            else if (String.Equals(unit, "mb", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "megabyte", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "megabytes", StringComparison.OrdinalIgnoreCase))
            {
                _ramUnitsType = 2;
            }
            else if (String.Equals(unit, "gb", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "gigabyte", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "gigabytes", StringComparison.OrdinalIgnoreCase))
            {
                _ramUnitsType = 3;
            }
            else if (String.Equals(unit, "tb", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "terabyte", StringComparison.OrdinalIgnoreCase)
                || String.Equals(unit, "terabytes", StringComparison.OrdinalIgnoreCase))
            {
                _ramUnitsType = 4;
            }
        }

        // [Funkcjonalny] Zwraca nazwę modelu zainstalowanej pamięci RAM
        public String GetModel()
        {
            return _partNumber;
        }

        // [Funkcjonalny] Zwraca nazwę producenta zainstalowanej pamięci RAM
        public String GetManufacturer()
        {
            return _manufacturer;
        }

        // [Funkcjonalny] Zwraca nazwę zintegrowanej karty graficznej
        public String GetMainGpuName()
        {
            return _gpuName1;
        }

        // [Funkcjonalny] Zwraca nazwę dedykowanej karty graficznej
        public String GetSecondGpuName()
        {
            return _gpuName2;
        }

        private IEnumerable<ManagementObject> WmiQuery(String query)
        {
            return new ManagementObjectSearcher(query).
                Get().Cast<ManagementObject>();
        }
    }
}
