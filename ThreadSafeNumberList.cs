using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shambala_ThreadsExampl_01_11_2023
{
    // класс для создания списка 
    internal class ThreadSafeNumberList
    {
        private List<int> numbers;
        // конструктор 
        public ThreadSafeNumberList()
        {
            numbers = new List<int>();
        }
        public int NumberCount
        {
            get
            {
                return numbers.Count;
            }
        }
        public void AddNNumbers(List<int> newNumbers)
        {
            numbers.AddRange(newNumbers);
        }
        public List<int> GetNumbers(int countNumbers)
        {
            int count = Math.Min(countNumbers, numbers.Count);
            int start = Math.Min(numbers.Count, NumberCount - countNumbers);
            var getNum = numbers.GetRange(start, count);
            numbers.RemoveRange(start,count);
            return getNum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var number in numbers)
            {
                sb.Append(number).Append(" ");
            }
            return $"Size :{numbers.Count}\n numbers {sb}" ;
        }
    }
}
