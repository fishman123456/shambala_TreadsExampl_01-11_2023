using shambala_ThreadsExampl_01_11_2023;

namespace shambala_TreadsExampl_01_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMonitor();
        }
        public static void RunMonitor()
        {
            // 1. Создание обьектов
            ThreadSafeNumberList numberList = new ThreadSafeNumberList();
            shambala_ThreadsExampl_01_11_2023.Monitor monitor = new shambala_ThreadsExampl_01_11_2023.Monitor(numberList,1000);
            Thread monitorThread = new Thread(monitor.Run); 
            monitorThread.Start();
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