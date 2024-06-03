using System;
using System.Linq;
using System.Windows.Forms;

namespace SP_Lab2
{
    public partial class Measurements : Form
    {
        private DataProcessing dataProcessing;

        public Measurements()
        {
            InitializeComponent();

            var result = Info.GetProcessorClockSpeedAndCoresCount();
            processorCoresCount.Value = result.Item1;
            processorClockSpeed.Value = result.Item2;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int size = (int)ArraySize.Value;
            int threads = (int)Threads.Value, delta_threads = (int)Delta_threads.Value;
            int k = (int)K.Value, delta_k = (int)Delta_K.Value;

            dataProcessing = new DataProcessing(size);
            var result1 = dataProcessing.GetThreadTimeDependency(k, threads, delta_threads);
            var result2 = dataProcessing.GetKTimeDependency(k, threads, delta_k);

            chart1.Series["Series1"].Points.DataBindXY(result1.Item1, result1.Item2);
            chart1.Series["Series2"].Points.DataBindXY(result1.Item1, result1.Item3);
            chart2.Series["Series1"].Points.DataBindXY(result2.Item1, result2.Item2);
            chart2.Series["Series2"].Points.DataBindXY(result2.Item1, result2.Item3);
            timeWithoutMultithreadingThreadPerTime.Value = (decimal)result1.Item2.LastOrDefault();
            timeWithMultithreadingThreadPerTime.Value = (decimal)result1.Item3.LastOrDefault();
            timeWithoutMultithreadingKPerTime.Value = (decimal)result2.Item2.LastOrDefault();
            timeWithMultithreadingKPerTime.Value = (decimal)result2.Item3.LastOrDefault();
        }

        private void Delta_threads_ValueChanged(object sender, EventArgs e)
        {
            if ((int)Delta_threads.Value > (int)Threads.Value)
            {
                Delta_threads.Value = Delta_threads.Minimum;
            }
        }

        private void Delta_K_ValueChanged(object sender, EventArgs e)
        {
            if ((int)Delta_K.Value > (int)K.Value)
            {
                Delta_K.Value = K.Minimum;
            }
        }

        private void Threads_ValueChanged(object sender, EventArgs e)
        {
            if ((int)Threads.Value > (int)ArraySize.Value)
            {
                Threads.Value = ArraySize.Value;    
            }
        }
    }
}
