using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskPrograms
{
    class TaskMethods
    {
        public void RunMethod() 
        {
            ShowThreadInfo("Application");

            var t = Task.Run(() => ShowThreadInfo("Task"));
            t.Wait();

        }
         public void ShowThreadInfo(String s)
        {
            Console.WriteLine("{0} Thread ID: {1}",
                              s, Thread.CurrentThread.ManagedThreadId);
        }


        //delay method

        public void DelayMethod() 
        {
            CancellationTokenSource source = new CancellationTokenSource();

            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1.5), source.Token);
                return 42;
            });
            source.Cancel();
            try
            {
                t.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }
            Console.Write("Task t Status: {0}", t.Status);
            if (t.Status == TaskStatus.RanToCompletion)
                Console.Write(", Result: {0}", t.Result);
            source.Dispose();
        }
        public void StartMethod() 
        
        {
            var t = new Task(() => {
                Console.WriteLine("Task {0} running on thread {1}",
                           Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                for (int ctr = 1; ctr <= 10; ctr++)
                    Console.WriteLine("   Iteration {0}", ctr);
            }
                       );
            t.Start();
            t.Wait();
        }

        public void Waitmethod() 
        {
            Task t = Task.Run(() => {
                Random rnd = new Random();
                long sum = 0;
                int n = 1000000;
                for (int ctr = 1; ctr <= n; ctr++)
                {
                    int number = rnd.Next(0, 101);
                    sum += number;
                }
                Console.WriteLine("Total:   {0:N0}", sum);
                Console.WriteLine("Mean:    {0:N2}", sum / n);
                Console.WriteLine("N:       {0:N0}", n);
            });
            t.Wait();
        }
    }
}
