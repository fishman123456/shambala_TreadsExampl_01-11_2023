using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shambala_ThreadsExampl_01_11_2023
{
    // класс вывода на консоль
    internal class Monitor
    {
        private ThreadSafeNumberList numberList;
        private int delay;
        public Monitor(ThreadSafeNumberList numberList, int delay)
        {
            this.numberList = numberList;
            this.delay = delay;
        }

        public void Run ()
        {
            while (true)
            {
                Console.WriteLine(numberList.ToString());
                Thread.Sleep(delay);
            }
            
        }
    }
}
