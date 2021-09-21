using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Введите целочисленные a и b по очереди для того, чтобы узнать площадь и периметр");

            int Square;
            int Perimeter;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Perimeter = 2 * (a + b);
            Square = a * b;

            Console.WriteLine($"Square = {Square}");
            Console.WriteLine($"Perimeter = {Perimeter}");

            Console.WriteLine("2. Введите диаметр для того, чтобы узнать длину окружности");

            double D;
            double pi;

            pi = 3.14;

            D = Convert.ToDouble(Console.ReadLine());
            double Length = pi * D;

            Console.WriteLine($"Длина: {Length}");

            Console.WriteLine("3. Введите числа a и b по очереди для того, чтобы узнать их среднее арифметическое значение");

            double a1;
            double b1;
            double Avarage;

            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());


            Avarage = (a1 + b1) / 2;

            Console.WriteLine($"Среднее арифметическое значение: {Avarage} ");

            Console.WriteLine("4. Введите числа два по очереди для того, чтобы узнать их сумму, разность, произведение и частное их квадратов");

            double a2;
            double b2;
            double Sum;
            double Ra;
            double Um;
            double Ke;

            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            a2 *= a2;
            b2 *= b2;

            Sum = a2 + b2;
            Ra = Math.Abs(a2 - b2);
            Um = a2 * b2;
            Ke = a2 / b2;

            Console.WriteLine($"Сумма: {Sum}, Разность: {Ra}, Произведение: {Um}, Частное: {Ke} ");

            Console.WriteLine("5. Введите числа два по очереди для того, чтобы узнать их сумму, разность, произведение и частное их модулей");

            double a3;
            double b3;
            double Summ;
            double Raa;
            double Umm;
            double Kee;

            a3 = Convert.ToDouble(Console.ReadLine());
            b3 = Convert.ToDouble(Console.ReadLine());
            a3 = Math.Abs(a3);
            b3 = Math.Abs(b3);

            Summ = a3 + b3;
            Raa = Math.Abs(a3 - b3);
            Umm = a3 * b3;
            Kee = a3 / b3;

            Console.WriteLine($"Сумма: {Summ}, Разность: {Raa}, Произведение: {Umm}, Частное: {Kee} ");

            Console.ReadKey();


        }
    }
}
