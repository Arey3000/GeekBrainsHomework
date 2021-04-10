using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checklogin
{
    class chklog
    {
        //Выполнил Шакун Кирилл
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        static bool chklogpass(string login, string pass)
        {
            if (login == "root" && pass == "GeekBrains")
                return true;
            else
                return false;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа проверки логина и пароля.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            int amounttries = 3;
            do
            {
                Console.WriteLine("Введите логин");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var pass = Console.ReadLine();
                Console.Clear();
                if (chklogpass(login, pass))
                {
                    break;
                }
                else
                {
                    amounttries--;
                    Console.WriteLine("Неверный ввод логина или пароля. Колцуичество попыток: " + amounttries);
                }
            } while (amounttries > 0);

            if (amounttries == 0) Console.WriteLine("Доступ заблокирован");
            else Console.WriteLine("Авторизирован");

            Console.ReadKey();
        }
    }
}
