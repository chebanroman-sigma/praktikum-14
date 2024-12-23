using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {/// <summary>
     /// Задание 4. С использованием цветового оформления консоли:
     /// б) вывести на экран вертикальную строку из 25 символов.
     /// </summary>



        //static void Func()
        //{
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    for (int i = 1; i <= 25; i++)
        //    {
        //        Console.WriteLine(" -");
        //    }
        //}

        ///////

        //        static void Func()
        //            Console.ForegroundColor = ConsoleColor.Blue;
        //        {
        //            int i = 1;
        //            while (i <= 25)
        //            {
        //                Console.WriteLine(" -");
        //                i++;
        //            }
        //}


        /// ///////

        //static void Func()
        //{
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    int i = 1;
        //    do
        //    {
        //        Console.WriteLine(" -");
        //        i++;
        //    } while (i <= 25);
        //}

        static void Main(string[] args)
        {
            Func();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
