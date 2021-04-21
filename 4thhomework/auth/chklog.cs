using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Autorisation
{
    internal class chklog
    {
        public struct Account
        {
            public string Login;
            public string Password;

            public void loadFromFile(string filename)
            {
                filename = "..\\..\\" + filename;
                StreamReader sr = new StreamReader(filename);

                Login = sr.ReadLine();

                Password = sr.ReadLine();

                sr.Close();
            }

        }
        public static bool CheckLogAndPass(Account toCheck)
        {
            if (toCheck.Login == "root" && toCheck.Password == "GeekBrains")
                return true;
            else
                return false;
        }

        public static void loginauth()
        {
            int AmountOfTries = 3;
            string[] fileName = { "data1.txt", "data2.txt", "data3.txt" };
            Account acc;
            acc.Login = "";
            acc.Password = "";
            int i = 0;
            do
            {
                Console.WriteLine("Загрузка: " + fileName[i]);
                acc.loadFromFile(fileName[i]);
                Console.Write("Авторизация........");
                System.Threading.Thread.Sleep(2000);
                if (CheckLogAndPass(acc))
                {
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine($"Неверный ввод логина или пароля." + "\nПопыток осталось :" + AmountOfTries);
                    System.Threading.Thread.Sleep(2000);
                }
                i++;
                Console.Clear();
            } while (AmountOfTries > 0);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Авторизация успешна!");
        }
    }
}