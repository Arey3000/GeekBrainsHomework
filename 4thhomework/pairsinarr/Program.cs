using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairsinarr
{
    //Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
    //Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    //В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Выполнил Шакун Кирилл
    class Program : arrclass
    {
        static void Main(string[] args)
        {
            const int arrayLength = 20;
            int[] myArray = new int[arrayLength];
            Random random = new Random();
            int result;
            Console.WriteLine("В следующем массиве  ");
            arrmeth(arrayLength, myArray, random);
            Console.WriteLine("  ");
            result = GetNumberOfPairs(myArray, arrayLength);
            Console.Write($"Всего пар: {result}");
            Console.ReadKey();
        }
    }
}
