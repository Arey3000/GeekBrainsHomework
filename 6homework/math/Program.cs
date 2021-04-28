﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
//выполнил Шакун Кирилл
namespace _6homework
{
    public delegate double Fun(double a, double x);

    class Program
    {


        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Таблица a*x^2:");
            Table(new Fun(MyFunc), -3.5, -4, 2);
            Console.WriteLine("Таблица a*sin(x):");
            Table(new Fun(MySin), 6, -3, 2);
            Console.ReadKey();
        }
    }

}
