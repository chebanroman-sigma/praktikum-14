using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {/// <summary>
     /// Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
     /// </summary>
     /// <param name="args"></param>
     /// 
        //static void Func()
        //{
        //    int x = 1;
        //    while(x<=10)
        //    {
        //        Console.WriteLine(x);
        //        x++;
        //    }
        //   
        //}
        //static void Func()
        //{
        //    int x = 1;
        //    do
        //    {
        //        Console.WriteLine(x);
        //        x++;
        //    }
        //    while (x <= 10);
        //}
        static void Func()
        {
            for (int x = 10; x >= 1; x--)
            {
                Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
