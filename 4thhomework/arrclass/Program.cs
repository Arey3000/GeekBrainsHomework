using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
//метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
//б)Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
namespace arrclass
{
   class Program : chkinp
    { 
        static void Main(string[] args)
        {
            Console.Write("Введите желаемый размер массива: ");
            int size = GetInt();
            Console.Write("Введите первый элемент массива: ");
            int firstElement = GetInt();
            Console.Write("Введите шаг для добавления последующих элементов: ");
            int step = GetInt();
            MyArray arrw = new MyArray(size, firstElement, step);
            Console.WriteLine("Создан массив: [ " + arrw.ToString() + " ]");
            Console.WriteLine("Сумма элементов массива: " + arrw.Sum);
            arrw.Inverse = -1;
            Console.WriteLine("Инверсия массива: [ " + arrw.ToString() + " ]");
            Console.Write("Введите число, на которое будут умножены элементы массива: ");
            arrw.Multi = GetInt();
            Console.WriteLine("Умножение массива: [ " + arrw.ToString() + " ]");
            Console.WriteLine("Максимальный элемент массива: " + arrw.Max);
            Console.WriteLine("Количество максимальных элементов массива: " + arrw.MaxCount);
            Console.WriteLine("Далее массив создаётся загрузкой данных из файла.");
            string fileName = "..\\..\\array1.txt";
            MyArray myArray = new MyArray(fileName);
            Console.WriteLine("Создан следующий массив: [" + myArray.ToString() + "]");
            string fileName2 = "..\\..\\array2.txt";
            Console.WriteLine("Загрузим массив из файла ["+ myArray.ToString()+"]");
            myArray.loadFromFile(fileName2);
            Console.WriteLine("Загружен следующий массив: [" + myArray.ToString() + "]");
            Console.WriteLine("Сохраним массив в файл " + fileName);
            myArray.saveIntoFile(fileName);
            MyArray myArray2 = new MyArray(fileName);
            Console.WriteLine("Проверим содержимое файла, загрузив из него новый массив: [" + myArray2.ToString() + "]");
            Console.ReadKey();
        }
    }
}
