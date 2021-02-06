using System;

namespace SimpleCodeHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рисуем треугольник");
            Console.Write("Введи ширину треугольника:"); int width = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j <= width; j++)
                {
                    for (int k = 0; k <= j; k++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int h = 0; h <= width; h++)
                {
                    for (int y = width; y >= h; y--)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                for (int n = 0; n <= width; n++)
                {
                    for (int t = width; t >= n; t--)
                    {
                        Console.Write(" ");
                    }
                    for (int r = 0; r <= n; r++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int m = width; m >= 0; m--)
                {
                    for (int t = width; t >= m; t--)
                    {
                        Console.Write(" ");
                    }

                    for (int t = 0; t <= m; t++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
            }

            }
            Console.ReadKey();           
        }
    }
}
