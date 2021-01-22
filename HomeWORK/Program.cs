using System;

namespace HomeWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчитать функцию (sinx + a*2.456)/x," +
                              "при изменении аргумента на отрезке [1;5] с шагом dx=0,123 и" +
                              "\nвывести на печать значение у>0,1.");
            Console.Write("Введите а = ");

            double a = double.Parse(Console.ReadLine());
            double x,y;

            for (x = 1; x <= 5; x += 0.123) 
            {
                y = (Math.Sin(x) + a * 2.456) / x;

                if (y > 0.1)
                {
                    Console.WriteLine($"(Sin({x}) + {a} * 2.456) / {x}={y};");
                }
            }

        }
    }
}
