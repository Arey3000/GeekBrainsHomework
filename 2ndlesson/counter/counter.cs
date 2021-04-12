using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    //Выполнил Шакун Кирилл
    //Написать метод подсчета количества цифр числа.
    class counter
    {
        static int Amount(string num)
        {
            return num.Length;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            var num = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Количество цифр: " + Amount(num));

            Console.ReadKey();


        }
    }
}
