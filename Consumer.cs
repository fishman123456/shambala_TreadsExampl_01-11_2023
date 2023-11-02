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
        private Random countNumber;
        private Random interval;
        private int minInterval;
        private int maxInterval;
        public Consumer(ThreadSafeNumberList numberList,
            Random countList,Random interval, int minInterval, int maxInterval)
        {
            this.numberList = numberList;
            this.countNumber = countList;
            this.interval = interval;
            this.minInterval = minInterval;
            this.maxInterval = maxInterval;
        }
        public void Run()
        {
            while (true)
            {
                numberList.GetNumbers(countNumber.Next(1,numberList.NumberCount));
                Thread.Sleep(interval.Next(maxInterval));
            }

        }
    }
}
