using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskPrograms
{
    class TaskIteration
    {
        public void Iteration()
        {
            Task t = Task.Factory.StartNew(() =>
            {

                int ctr = 0;
                for (ctr = 0; ctr <= 100; ctr++)
                { }
                Console.WriteLine("Finished {0} loop iterations",
                                  ctr);
            });
        }

    }
}


