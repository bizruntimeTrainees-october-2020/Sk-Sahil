using System;

using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskPrograms
{
    class FourTasks
    {
        public void WorkingOfThreads() 
        {
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                Task.CurrentId, obj,
                Thread.CurrentThread.ManagedThreadId);
            };
            Task t1 = new Task(action, "alpha");
            Task t2 = Task.Factory.StartNew(action, "beta");
            t2.Wait();
            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                          Thread.CurrentThread.ManagedThreadId);
            t1.Wait();
            String taskData = "delta";
            Task t3 = Task.Run(() => {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                             Task.CurrentId, taskData,
                              Thread.CurrentThread.ManagedThreadId);
            });
            t3.Wait();
            Task t4 = new Task(action, "gamma");
            t4.RunSynchronously();
            t4.Wait();
        }

    }
}
