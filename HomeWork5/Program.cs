using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить и напечатать значения функции и соответствующие им значения аргументов x, y." +
                              "\nz=2xy-2yx при изменении первого аргумента" +
                              "\nx[-1;1] с шагом 0,1 и второго аргумента y[-2;2] с шагом 0,2. ");

            double x, y,number;

            for ( x = -1, y = -2; x <= 1 && y <= 2; x+=0.1, y+=0.2 )
            {
                number = 2 * y * x - 2 * y * x;
                Console.WriteLine($"2 * {x} * {y} - 2 * {y} * {x} = {number}");
            }
        }
    }
}
