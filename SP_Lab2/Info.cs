using System.Management;

namespace SP_Lab2
{
    internal static class Info
    {
        public static (decimal, decimal) GetProcessorClockSpeedAndCoresCount()
        {
            uint coresCount = 0, clockSpeed = 0;
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (var item in searcher.Get())
            {
                coresCount += (uint)item["NumberOfCores"];
                clockSpeed = (uint)item["MaxClockSpeed"];
            }

            return (coresCount, clockSpeed);
        }
    }
}
