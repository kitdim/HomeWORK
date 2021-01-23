using System;

namespace HOMEWORK3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести на экран последовательность чисел y, " +
                             "\nявляющихся результатом выполнения операции y = A sin x, где A=0,5," +
                             "\nа переменная x изменяется от 1 до 10 с шагом 1.");
            Console.WriteLine();

            double A = 0.5;
            double x = 1;

            while(x<=10)
            {
                Console.WriteLine($"{A} * sin {x} = {A*Math.Sin(x)}");
                x++;
            }
        }
    }
}
