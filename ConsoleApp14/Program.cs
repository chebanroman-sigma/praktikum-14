using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {/// <summary>
     /// Задание 4. С использованием цветового оформления консоли:

     ///  а) вывести на экран горизонтальную строку из 18 символов;
     /// </summary>

        //static void Func()
        //{
        //  Console.ForegroundColor = ConsoleColor.Blue;
        //    for (int i = 1; i <= 18; i++)
        //    {  
        //        Console.Write(" -");
        //    }   
        //}

        ///////

//        static void Func()
//            Console.ForegroundColor = ConsoleColor.Blue;
//        {
//            int i = 1;
//            while (i <= 18)
//            {
//                Console.Write(" -");
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
//        Console.Write(" -");
//        i++;
//    } while (i <= 18);
//}

static void Main(string[] args)
        {
            Func();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
