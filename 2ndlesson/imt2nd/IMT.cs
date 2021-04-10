using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imt2nd
{

    class IMT
    {
        //        а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        
        static string chkweight(double imt, double h)
        {
            var res = "";

            if (imt >= 18.5 && imt <= 24.99)
            {
                res = "Ваш вес в норме";
            }
            else if (imt < 18.5)
            {
                double rec = (18.5 - imt) * h * h;
                rec = Math.Round(rec, 2);
                res = String.Format($"Наберите {rec} кг для нормализации веса!");
            }
            else if (imt > 24.99)
            {
                double rec = (imt - 24.99) * h * h;
                rec = Math.Round(rec, 2);
                res = String.Format($"Сбросьте {rec} кг для нормализации веса!");
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.Title = "Расчет ИМТ";

            Console.SetWindowSize(Console.WindowWidth, 54);
            Console.SetWindowSize(Console.WindowHeight, 20);
            double m, h, imt;
            
            Console.WriteLine("Здравствуйте. Давайте узнаем ваш индекс массы тела");
            System.Threading.Thread.Sleep(2000); //Пауза две секунды
            Console.Clear();

            #region Ввод данных
            Console.WriteLine("Введите ваш вес");
            m = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите ваш рост");
            h = double.Parse(Console.ReadLine());      
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            #endregion
            
            #region Вывод параметров
            imt = im(m, ref h);
            Console.WriteLine($"Ваш индекс массы тела : {imt}");
            System.Threading.Thread.Sleep(2000);  
            Console.WriteLine(chkweight(imt, h));
            System.Threading.Thread.Sleep(2000);
            #endregion

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
        private static double im(double m, ref double h) //расчет ИМТ
        {
            double imt;
            h = h / 100;
            imt = m / (h * h);
            imt = Math.Round(imt, 2);
            return imt;
        }
    }
}
