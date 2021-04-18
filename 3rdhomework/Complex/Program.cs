using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{

    class Program
    {
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //Выполнил Шакун Кирилл
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine("Результат работы структуры:");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результом сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результом умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());
            result = complex1.Minus(complex2); 
            Console.WriteLine("Результом вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());

            Console.WriteLine();

            Console.WriteLine("Результат работы класса:");
            ClassComplex ccomplex1 = new ClassComplex(1, 1);
            ClassComplex ccomplex2 = new ClassComplex(2, 2);

            ClassComplex cresult = ccomplex1.Plus(ccomplex2);
            Console.WriteLine("Результом сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                + cresult.ToString());
            cresult = ccomplex1.Multi(ccomplex2);
            Console.WriteLine("Результом умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());
            cresult = ccomplex1.Minus(ccomplex2);
            Console.WriteLine("Результом вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());


            Complex res = new Complex();
            Console.WriteLine("Тип операции: сложение(+) , вычитание(-) , умножение(*)");
            var choice = Console.ReadLine();
                switch (choice)
                {
                    case "+":
                        result = complex1.Plus(complex2);
                        {
                            Console.WriteLine(result.ToString()); break;
                        }
                    case "-":
                        result = complex1.Minus(complex2);
                        {
                            Console.WriteLine(result.ToString()); break;
                        }
                    case "*":
                        result = complex1.Multi(complex2);
                        {
                            Console.WriteLine(result.ToString()); break;
                        }
                    default: Console.WriteLine("Такой операции нет"); break;
                }
            
            Console.ReadKey();
        }
    }
}
