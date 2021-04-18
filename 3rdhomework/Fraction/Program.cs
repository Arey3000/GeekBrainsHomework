using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    //3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    //Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    //Написать программу, демонстрирующую все разработанные элементы класса.
    //Выполнил Шакун Кирилл
    class Program
    {
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Требуется числовое значение.");
                else return x;
        }

        static Fraction Init(int numerator, int denumerator)
        {
            bool checkException;
            Fraction fraction = null;
            do
            {
                checkException = false;
                try
                {
                    fraction = new Fraction(numerator, denumerator);
                }
                catch (ArgumentException ex)
                {
                    checkException = true;
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.Write("Повторно введите знаменатель дроби: ");
                    denumerator = GetInt();
                }
            } while (checkException);
            
            return fraction;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа работы с дробями!");
            Console.WriteLine("Введите числитель первой дроби: ");
            int n1 = GetInt();
            Console.WriteLine("Введите знаменатель первой дроби: ");
            int d1 = GetInt();
            Console.WriteLine("Введите числитель второй дроби: ");
            int n2 = GetInt();
            Console.WriteLine("Введите знаменатель второй дроби: ");
            int d2 = GetInt();
            Fraction fraction1 = Init(n1, d1);
            Fraction fraction2= Init(n2, d2);

            Console.WriteLine();
            Fraction result = fraction1.Plus(fraction2);
            result.Simplification();
            Console.WriteLine("Результом сложения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
                + result.ToString());
            result = fraction1.Minus(fraction2);
            result.Simplification();
            Console.WriteLine("Результом вычитания чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());
            result = fraction1.Multi(fraction2);
            result.Simplification();
            Console.WriteLine("Результом умножения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());
            result = fraction1.Division(fraction2);
            result.Simplification();
            Console.WriteLine("Результомделения чисел: " + fraction1.ToString() + " и " + fraction2.ToString() + " является "
               + result.ToString());

            Console.ReadKey();
        }
    }
}
