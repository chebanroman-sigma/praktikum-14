using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {/// <summary>
     /// Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
     /// </summary>
     /// <param name="args"></param>
     /// 
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        //static void Func()
        //{
        //    int n = Input("Введите n ");

        //    for (int x = 1; x <= n; x++)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
        //static void Func()
        //{
        //    int n = Input("n= ");
        //        int x = 1;
        //    while (x <= n) 
        //    { 
        //            Console.WriteLine(x);
        //                x++;
        //    }
        //}
        //static void Func()
        //{
        //    int n = Input("Введите n ");
        //    int x = 1;
        //    do
        //    {
        //        Console.WriteLine(x);
        //        x++;
                
        //    } while (x <= n) ;      
        //}
        static void Main(string[] args)

        {
            Func();
            Console.ReadKey();
        }
    }
}
