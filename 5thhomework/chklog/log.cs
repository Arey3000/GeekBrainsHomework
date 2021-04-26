using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace CorrectLogin
{
    internal class log
    {
        public static bool chklog(string log)
        {
            int length = log.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = log[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = log[i];
                    if (!(Char.IsDigit(letter) || latin(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }
        public static bool chklogr(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }
        public static bool latin(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }
        public static void loginprog()
        {
            Console.WriteLine("Проверка корректного вода логина.");
            int AmountOfTries = 3;
            do
            {
                Console.Write("Введите ваш логин: ");
                var login = Console.ReadLine();
                if (chklog(login) && chklogr(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина."
                        + "\nДлина строки 2 до 10 символов;"
                        + "\nБуквы только латинского алфавита или цифры;"
                        + "\nЦифра не может быть первой."
                        + Environment.NewLine + "Попыток осталось:  " + AmountOfTries);
                }
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            } while (AmountOfTries > 0);
                Console.WriteLine("Корректный ввод");
            Console.ReadKey();
        }
    }
}