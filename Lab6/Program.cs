using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Задание 1
                int A, B;
                Console.WriteLine("Введите A и B по очереди ");
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                (A, B) = (B, A); // Подмена
                Console.WriteLine($"A={A}, B={B}");
            }
            {
                // Задание 2
                Console.WriteLine();

                int A, B, C;
                Console.WriteLine("Введите A, B и С поочередно");

                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());

                (A, B, C) = (C, A, B); // Подмена

                Console.WriteLine($"A={A},B={B},C={C}");
            }
            {
                // Задание 3
                Console.WriteLine();

                int A, B, C;
                Console.WriteLine("Введите A, B и С поочередно");

                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());

                (A, B, C) = (B, C, A); // Подмена

                Console.WriteLine($"A={A},B={B},C={C}");
            }
            {
                // Задание 4
                double x,y;

                Console.WriteLine("");
                Console.WriteLine("Введите x");
                x = Convert.ToDouble(Console.ReadLine());

                y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;

                Console.WriteLine($"Функция y = {y}");
            }
            {
                // Задание 5
                double x, y;

                Console.WriteLine("");
                Console.WriteLine("Введите x");
                x = Convert.ToDouble(Console.ReadLine());

                y = 4*Math.Pow(x-3,6) - 7*(Math.Pow(x-3,3)) + 2;

                Console.WriteLine($"Функция y = {y}");
            }
            {
                // Задание 6
                Console.WriteLine("");

                double A;
                double B;

                Console.WriteLine("Введите A");
                A = Convert.ToDouble(Console.ReadLine());

                B = A;
                A = B * A;
                A *= A;
                A *= A;

                Console.WriteLine($"{A}");
            }
            {
                // Задание 7
                Console.WriteLine("");

                double A;
                double B;
                double C;

                Console.WriteLine("Введите A");
                A = Convert.ToDouble(Console.ReadLine());

                B = A;
                A = B * A * B;
                C = A;
                A *= A;
                A *= A;
                A *= C;

                Console.WriteLine($"{A}");
            }
        }
    }
}
