using System;

namespace HomeWORK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Составить программу вычисления и вывода на экран значений величин x и y, где y=A*sqrX." +
                              "\nПеременная x изменяется в интервале от 0,75 до 1,5 c шагом 0,5. A=5");

            double A = 5;
            double x = 0.75;

            while(x<=1.5)
            {
                Console.WriteLine($"{A}*sqrt{x}={A*Math.Sqrt(x)}");
                x += 0.5;
            }
        }
    }
}
