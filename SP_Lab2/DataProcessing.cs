using System;
using System.Collections.Generic;
using System.Threading;

namespace SP_Lab2
{
    internal class DataProcessing
    {
        public double[] A { get; }
        public double[] B { get; }

        public DataProcessing(int size)
        {
            A = new double[size];
            B = new double[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                A[i] = random.NextDouble();
            }
        }

        private void Processing(int start, int end, int K)
        {
            for (int i = start; i < end; i++)
            {
                for (int j = 0; j < K; j++)
                    B[i] += Math.Pow(A[i], 1.789);
            }
        }

        private TimeSpan ProcessingWithoutMultithreading(int K)
        {
            DateTime startTime = DateTime.Now;
            Processing(0, A.Length, K);
            DateTime endTime = DateTime.Now;
            return endTime - startTime;
        }

        private TimeSpan ProcessingWithMultithreading(int K, int N_threads)
        {
            DateTime startTime = DateTime.Now;
            Thread[] threads = new Thread[N_threads];

            for (int i = 0; i < threads.Length; i++)
            {
                int start = i * A.Length / threads.Length;
                int end = (i + 1) * A.Length / threads.Length;
                threads[i] = new Thread(() => Processing(start, end, K));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            DateTime endTime = DateTime.Now;
            return endTime - startTime;
        }

        public (List<int>, List<double>, List<double>) GetThreadTimeDependency(int K, int N_threads, int Delta_threads)
        {
            var threadTimeDependency = (new List<int>(), new List<double>(), new List<double>());

            for (int i = 1; i <= N_threads; i += Delta_threads)
            {
                threadTimeDependency.Item1.Add(i);
                var timeWithoutMultithreading = ProcessingWithoutMultithreading(K);
                threadTimeDependency.Item2.Add(timeWithoutMultithreading.TotalMilliseconds);
                var timeWithMultithreading = ProcessingWithMultithreading(K, i);
                threadTimeDependency.Item3.Add(timeWithMultithreading.TotalMilliseconds);
            }

            return threadTimeDependency;
        }

        public (List<int>, List<double>, List<double>) GetKTimeDependency(int K, int N_threads, int Delta_K)
        {
            var kTimeDependency = (new List<int>(), new List<double>(), new List<double>());

            for (int i = 1; i <= K; i += Delta_K)
            {
                kTimeDependency.Item1.Add(i);
                var timeWithoutMultithreading = ProcessingWithoutMultithreading(i);
                kTimeDependency.Item2.Add(timeWithoutMultithreading.TotalMilliseconds);
                var timeWithMultithreading = ProcessingWithMultithreading(i, N_threads);
                kTimeDependency.Item3.Add(timeWithMultithreading.TotalMilliseconds);
            }

            return kTimeDependency;
        }
    }
}
