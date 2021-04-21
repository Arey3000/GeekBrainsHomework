using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
//Выполнил Шакун Кирилл
namespace Autorisation
{
    class Program : chklog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте проверим логин и пароль из файла");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            loginauth();
            Console.ReadKey();
        }
    }
}