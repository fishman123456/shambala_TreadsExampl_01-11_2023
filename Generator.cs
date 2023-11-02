using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shambala_ThreadsExampl_01_11_2023
{
    internal class Generator
    {
        private ThreadSafeNumberList numberList;
        private int listlimit;
        private Random random;
        private int minValue;
        private int maxValue;
        public Generator(ThreadSafeNumberList numberList, int listlimit, Random random,
            int minValue, int maxValue)
        {
            this.numberList = numberList;
            this.listlimit = listlimit;
            this.random = random;
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
        public void AddNumber()
        {
            int numbercount = numberList.NumberCount;
            if (numberList.NumberCount < listlimit) 
            {
                List <int> numbers = new List<int>();
                for (int i = 0; i < listlimit-numbercount; i++)
                {
                    numbers.Add(random.Next(minValue,maxValue));
                }
            numberList.AddNNumbers(numbers);
            }
        }
      
    }
}
