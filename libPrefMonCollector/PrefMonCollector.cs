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
        private PerformanceCounter cpuCounter;
        private PerformanceCounter cpuTempCounter;
        private PerformanceCounter ramCounter;

        private static Boolean collectorRunning = false;

        private List<double> cpuUsageHistory = new List<double>();
        private List<double> cpuTempeHistory = new List<double>();
        private List<double> ramFreeMemHistory = new List<double>();

        public PrefMonCollector()
        {
            cpuCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
            cpuTempCounter = new PerformanceCounter("Thermal Zone Information", "Temperature", @"\_TZ.TZ00");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            startTask();
        }

        ~PrefMonCollector()
        {
            stopTask();
        }

        public double getCurrentCpuUsage(double res)
        {
            List<double> temp = cpuUsageHistory;

            double sum = 0;

            for (int i = temp.Count - 1; i > (temp.Count - 1 - res) && 0 < (temp.Count - 1 - res); i--)
            {
                sum += temp.ElementAt(i);
            }

            return sum / res;
        }

        public List<double> getCpuUsageHistory()
        {
            return cpuUsageHistory;
        }

        public double getCurrentCpuTemp(double res)
        {
            List<double> temp = cpuTempeHistory;

            double sum = 0;

            for (int i = temp.Count - 1; i > (temp.Count - 1 - res) && 0 < (temp.Count - 1 - res); i--)
            {
                sum += temp.ElementAt(i);
            }

            return sum / res;
        }

        public List<double> getCpuTempHistory()
        {
            return cpuTempeHistory;
        }

        public double getCurrentRamFreeMem()
        {
            List<double> temp = ramFreeMemHistory;

            return temp.ElementAt(temp.Count - 1);
        }

        public List<double> getRamFreeMemHistory()
        {
            return ramFreeMemHistory;
        }

        // Updates every 1000ms (The value associated with each performance counter is updated every 400 milliseconds.)
        private async Task gatherData()
        {
            while (collectorRunning)
            {
                // USAGE
                var delayTask = Task.Delay(500);
                if (cpuUsageHistory.Count == 100)
                {
                    cpuUsageHistory.RemoveAt(0);
                }
                double c = cpuCounter.NextValue();
                cpuUsageHistory.Add(c);


                // TEMP
                if (cpuTempeHistory.Count == 100)
                {
                    cpuTempeHistory.RemoveAt(0);
                }
                double t = (cpuTempCounter.NextValue() - 273.15);
                cpuTempeHistory.Add(t);


                // RAM
                if (ramFreeMemHistory.Count == 100)
                {
                    ramFreeMemHistory.RemoveAt(0);
                }
                double r = ramCounter.NextValue();
                ramFreeMemHistory.Add(r);

                await delayTask;
            }
        }

        private void startTask()
        {
            collectorRunning = true;
            gatherData();
        }

        private void stopTask()
        {
            collectorRunning = false;
        }
    }
}
