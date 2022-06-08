using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPrefMonCollector
{
    public class PrefMonCollector
    {
        // Zdefiniowanie zmiennych prywatnych
        private PerformanceCounter _cpuCounter;
        private PerformanceCounter _cpuTempCounter;
        private PerformanceCounter _ramCounter;

        private static Boolean _collectorRunning = false;

        private List<Double> _cpuUsageHistory = new List<Double>();
        private List<Double> _cpuTempeHistory = new List<Double>();
        private List<Double> _ramFreeMemHistory = new List<Double>();

        private System.TimeSpan _updateInterval;
        private UInt32 _cpuTempPrecision;
        private UInt32 _cpuUsagePrecision;

        // Konstruktor PrefMonCollector
        public PrefMonCollector()
        {
            // Inicjalizacja zmiennych prywatnych
            _cpuCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
            _cpuTempCounter = new PerformanceCounter("Thermal Zone Information", "Temperature", @"\_TZ.TZ00");
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            SetUpdateInterval(500);
            SetCpuTemparaturePrecision(0);
            SetCpuUsagePrecision(0);
        }
        
        // Destruktor PrefMonCollector
        ~PrefMonCollector()
        {
            StopDataCollectiong();
        }

        // [Niefunkcjonalny] Ustawia częstotliwość aktualiacji danych
        public void SetUpdateInterval(UInt32 ms)
        {
            _updateInterval = new System.TimeSpan(0, 0, 0, 0, Convert.ToInt32(ms));
        }

        // [Funkcjonalny] Uruchamia w tle proces który zbiera statystyki (użycia procesora, temperatury, wolnej pamięci RAM),
        // przechowuje maksymalnie 100 próbek
        public void StartDataCollecting()
        {
            if (_collectorRunning == false)
            {
                _collectorRunning = true;
                GatherData();
            }
        }

        // [Funkcjonalny] Zatrzymuje proces zbierający statystyki
        public void StopDataCollectiong()
        {
            _collectorRunning = false;
        }

        // [Niefunkcjonalny] Ustawia precyzje do n miejsc po przecinku przy wyświetlaniu użycia procesora
        public void SetCpuUsagePrecision(UInt32 n)
        {
            _cpuUsagePrecision = n;
        }

        // [Funkcjonalny] Zwraca aktualne średnie użycie procesora z ostatnich N próbek 
        public Double GetCurrentCpuUsage(Double n)
        {
            List<Double> temp = _cpuUsageHistory;

            Double sum = 0;

            for (Int32 i = temp.Count - 1; i > (temp.Count - 1 - n) && 0 < (temp.Count - 1 - n); i--)
            {
                sum += temp.ElementAt(i);
            }

            return Math.Round(sum / n, Convert.ToInt32(_cpuUsagePrecision));
        }

        // [Funkcjonalny] Zwraca tablice z historią użycia procesora dla ostatnich <=100 próbek
        public List<Double> GetCpuUsageHistory()
        {
            return _cpuUsageHistory;
        }

        // [Niefunkcjonalny] Ustawia precyzje do n miejsc po przecinku przy wyświetlaniu temperatury procesora
        public void SetCpuTemparaturePrecision(UInt32 n)
        {
            _cpuTempPrecision = n;
        }

        // [Funkcjonalny] Zwraca aktualną średnią temperature procesora z ostatnich N próbek
        public Double GetCurrentCpuTemp(Double n)
        {
            List<Double> temp = _cpuTempeHistory;

            Double sum = 0;

            for (Int32 i = temp.Count - 1; i > (temp.Count - 1 - n) && 0 < (temp.Count - 1 - n); i--)
            {
                sum += temp.ElementAt(i);
            }

            return Math.Round(sum / n, Convert.ToInt32(_cpuTempPrecision));
        }

        // [Funkcjonalny] Zwraca tablice z historią temperatur procesora dla ostatnich <=100 próbek
        public List<Double> GetCpuTempHistory()
        {
            return _cpuTempeHistory;
        }

        // [Funkcjonalny] Zwraca aktualną ilość wolnej pamięci RAM
        public Double GetCurrentRamFreeMem()
        {
            List<Double> temp = _ramFreeMemHistory;

            return temp.ElementAt(temp.Count - 1);
        }

        // [Funkcjonalny] Zwraca tablice z historią "wolnej ilości pamięci RAM" z ostatnich <=100 próbek
        public List<Double> GetRamFreeMemHistory()
        {
            return _ramFreeMemHistory;
        }

        // Updates every 1000ms (The value associated with each performance counter is updated every 400 milliseconds.)
        private async Task GatherData()
        {
            while (_collectorRunning)
            {
                // USAGE
                Task delayTask = Task.Delay(_updateInterval);
                if (_cpuUsageHistory.Count == 100)
                {
                    _cpuUsageHistory.RemoveAt(0);
                }
                Double c = _cpuCounter.NextValue();
                _cpuUsageHistory.Add(c);

                // TEMP
                if (_cpuTempeHistory.Count == 100)
                {
                    _cpuTempeHistory.RemoveAt(0);
                }
                Double t = (_cpuTempCounter.NextValue() - 273.15);
                _cpuTempeHistory.Add(t);

                // RAM
                if (_ramFreeMemHistory.Count == 100)
                {
                    _ramFreeMemHistory.RemoveAt(0);
                }
                Double r = _ramCounter.NextValue();
                _ramFreeMemHistory.Add(r);

                await delayTask;
            }
        }
    }
}
