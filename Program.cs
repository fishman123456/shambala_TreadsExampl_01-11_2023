using shambala_ThreadsExampl_01_11_2023;

using Monitor = shambala_ThreadsExampl_01_11_2023.Monitor;

namespace shambala_TreadsExampl_01_11_2023
{
    internal class Program
    {
        public static void RunMonitor()
        {
            // 1. Создание обьектов
            ThreadSafeNumberList numberList = new ThreadSafeNumberList();
            shambala_ThreadsExampl_01_11_2023.Monitor monitor = new shambala_ThreadsExampl_01_11_2023.Monitor(numberList, 1000);
            Thread monitorThread = new Thread(monitor.Run);
            monitorThread.Start();
        }
        // создаём генератор 
        public static void RunGeneratorMonitor()
        {
            Random random = new Random();
            ThreadSafeNumberList numberList = new ThreadSafeNumberList();
            Generator generator = new Generator(numberList, 1000,random,10,10,10);
            shambala_ThreadsExampl_01_11_2023.Monitor monitor = new shambala_ThreadsExampl_01_11_2023.Monitor(numberList, 1000);
            System.Threading.Thread monitorThread = new System.Threading.Thread(monitor.Run);
            System.Threading.Thread monitorThreads = new System.Threading.Thread(generator.Run);
        }
        public static void RunConsumer(int count)
        {
            ThreadSafeNumberList numberList = new ThreadSafeNumberList();
            Monitor monitor = new Monitor(numberList,1000);
            Random random = new Random();
            Generator generator = new Generator(numberList,10,random,0,10,3000);
            Consumer consumer = new Consumer( numberList,random,0,10,3000);
        }
        static void Main(string[] args)
        {
            RunMonitor();
            RunGeneratorMonitor();
            RunConsumer(5);
        }
     
      
       
    }
}
// ЗАДАЧА: написать программу наполнения списка случайных чисел

// существует 2 типа потоков:
// 1) генератор - поток обеспечивает существование списка случайных чисел заданной длины
// если длина списка становится меньше чем заданная длина, то генератор дописывает случайные числа в список

// 2) потребители - потоки, которые обращаются к списку случайных чисел и извлекают из него
// случайные числа в заданном количестве с конца (если чисел меньше, то извлекаем сколько есть)
// при извлечение чисел они удаляются из списка

// 3) монитор - поток, который переодически выводит на экран содержимое списка