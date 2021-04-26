using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thhomework
{
    internal class chk
    {

        public static void chkstring()
        {
            Console.Write("Введите первую строку:  ");
            var first = Console.ReadLine();
            Console.Write("Введите вторую строку:  ");
            var second = Console.ReadLine();
            Console.WriteLine("Проверим их");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            if (chkstrg(first, second) == true)
                Console.WriteLine("Строки являются перестановками друг друга.");
            else
                Console.WriteLine("Строки состоят из разных символов.");
            Console.ReadKey();
        }

        static bool chkstrg(string s1, string s2)
        { 
            return s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));
        }
    }
}