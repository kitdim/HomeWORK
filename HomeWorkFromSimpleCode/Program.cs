using System;

namespace HomeWorkFromSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("В заданном пользователем количестве чисел, подсчитать количество чётных и нечетных чисел");


            Console.Write("Введите начало:=");                     int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите конец:=");                      int limitNumber = int.Parse(Console.ReadLine());
                                                                   int EvenNumber = 0; int EvenNumberSum = 0;
                                                                   int OddNumber = 0;  int OddNumberSum = 0;



            while (startNumber<=limitNumber)
            {

                if(startNumber % 2==0)
                {
                    EvenNumber++;
                    EvenNumberSum += startNumber;
                }
                else
                {
                    OddNumber++;
                    OddNumberSum += startNumber;
                }
                startNumber++;                                 
            }

            Console.WriteLine("Количество чётных чисел:"+EvenNumber+"\tСумма чётных чисел:"+EvenNumberSum); 
            Console.WriteLine("Количество нечётных чисел:"+OddNumber+"\tСумма нечётных чисел:" + OddNumberSum);
            Console.ReadLine();
            
        }
    }
}
