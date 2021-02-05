using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести три действительных числа. Определить, какие из них принадлежат интервалу (1, 5)" +
                              "\nи дать об этом сообщение на печать.");
            
            Console.WriteLine("");
            Console.Write("Write one number, please:");      int OneNumber = int.Parse(Console.ReadLine());
            Console.Write("Write two number, please:");      int TwoNumber = int.Parse(Console.ReadLine());
            Console.Write("Write three number, please:");    int ThreeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (OneNumber>=1 && OneNumber<=5)
            {
                Console.WriteLine($"Number {OneNumber} in the range 1-5");
            }
            else
            {
                Console.WriteLine($"Number {OneNumber} is out of range 1-5");
            }

            if (TwoNumber >= 1 && TwoNumber <= 5)
            {
                Console.WriteLine($"Number {TwoNumber} in the range 1-5");
            }
            else
            {
                Console.WriteLine($"Number {TwoNumber} is out of range 1-5");
            }

            if (ThreeNumber >= 1 && ThreeNumber <= 5)
            {
                Console.WriteLine($"Number {ThreeNumber} in the range 1-5");
            }
            else
            {
                Console.WriteLine($"Number {ThreeNumber} is out of range 1-5");
            }
        }
    }
}
