using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumpositive
{
    class sumpos
    {
        //Выполнил Шакун Кирилл
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа по одному, для завершения введите '0':");

            int amount = 0;
            int sum = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                else if (num > 0 && num % 2 == 1)
                {
                    amount++;
                    sum += num;
                }
            }

            clp();

            Console.WriteLine("Количество чисел: " + amount);
            Console.WriteLine("Сумма чисел: " + sum);

            Console.ReadKey();
        }

        private static void clp()
        {
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
