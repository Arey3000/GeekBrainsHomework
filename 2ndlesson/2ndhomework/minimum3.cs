using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndhomework
{
    class minimum3
    {
        //Выполнил Шакун Кирилл
        //Написать метод, возвращающий минимальное из трёх чисел.

        static int minimum (int a, int b, int c)
        {
            int min;

            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            return min;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Введите третье число:");
            int c = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.Write("Минимальным является: " + minimum(a, b, c));

            Console.ReadKey();
        }

    }
}
