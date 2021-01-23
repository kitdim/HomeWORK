using System;

namespace HOMEWORK4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Составить программу вычисления произведения элементов, значения которых укладываются в интервал от 1 до 10.");

            Console.Write("Введите первое число:="); double OneNumber = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число:="); double TwoNumber = double.Parse(Console.ReadLine());           
                                                     double EndOfCycle = 1;

            while(EndOfCycle<=10)
            {
                Console.WriteLine($"{OneNumber}*{TwoNumber}={OneNumber*TwoNumber}");
                EndOfCycle++;
            }
            

        }
    }
}
