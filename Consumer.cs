using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shambala_ThreadsExampl_01_11_2023
{
    internal class Consumer
    {
        private ThreadSafeNumberList numberList;
        private Random random;
        private Random interval;
        private int minInterval;
        private int maxInterval;
        private int maxCount;
        public Consumer(ThreadSafeNumberList numberList,
            Random random, int minInterval, int maxInterval,
            int maxCount)
        {
            this.numberList = numberList;
            this.minInterval = minInterval;
            this.maxInterval = maxInterval;
            this.maxCount = maxCount;
        }
        public void Run()
        {
            while (true)
            {
                int countNumbers = random.Next(1, numberList.maxCount + 1);
                numberList.GetNumbers(countNumbers);
                int interval = random.Next(minInterval, maxInterval);
                Thread.Sleep(interval);
            }

        }
    }
}
