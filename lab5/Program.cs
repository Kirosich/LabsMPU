using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.");
            double x1, y1, x2, y2;
            Console.WriteLine("Введите x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            double Res1;

            Res1 = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
            Console.WriteLine($"Расстояние: {Res1}");

            int A, B, C;

            Console.WriteLine("Задание 2.");

            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C");
            C = Convert.ToInt32(Console.ReadLine());


            int AC = Math.Abs(C - A);
            int BC = Math.Abs(C - B);
            int SUMBCAC = AC + BC;
            Console.WriteLine($"AC = {AC}, BC = {BC}, Sum = {SUMBCAC}");

            Console.WriteLine("Задание 3.");

            int a, b, c;

            Console.WriteLine("Введите A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C, по условиям C < B, C > A, B > A ");
            
            c = Convert.ToInt32(Console.ReadLine());

            if (c < a || c > b || (c < a & c > b))
            {
                Console.WriteLine("Введите C по условию!");
                c = Convert.ToInt32(Console.ReadLine());
            }

            int ac = Math.Abs(c - a);
            int bc = Math.Abs(c - b);
            int sumbac = ac + bc;
            Console.WriteLine($"AC = {ac}, BC = {bc}, Sum = {sumbac}");

            Console.WriteLine("Задание 4.");

            double x11, y11, x22, y22, StrB, StrA, Square, Perimeter;

            Console.WriteLine("Введите x1");
            x11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y22 = Convert.ToDouble(Console.ReadLine());

            StrB = Math.Abs(x22 - x11);
            StrA = Math.Abs(y22 - y11);

            Square = StrB * StrA;
            Perimeter = 2 * (StrB + StrA);

            Console.WriteLine($"Square = {Square}, Perimeter = {Perimeter}");

            Console.WriteLine("Задание 5.");

            double x111, y111, x222, y222, StrBB, StrAA,StrCC, Squaree, Perimeterr, x333,y333, Perimeterr1;

            Console.WriteLine("Введите x1");
            x111 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x222 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x3");
            x333 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y111 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y222 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y3");
            y333 = Convert.ToDouble(Console.ReadLine());

            StrCC = Math.Sqrt(Math.Pow(x222 - x111, 2) + Math.Pow(y222 - y111, 2));
            StrBB = Math.Sqrt(Math.Pow(x333 - x111, 2) + Math.Pow(y333 - y111, 2));
            StrAA = Math.Sqrt(Math.Pow(x333 - x222, 2) + Math.Pow(y333 - y222, 2));

            Perimeterr = StrCC + StrBB + StrAA;
            Perimeterr1 = Perimeterr / 2;
            Squaree = Math.Sqrt(Perimeterr1*(Perimeterr1 - StrAA) * (Perimeterr1 - StrCC) * (Perimeterr1 - StrBB));

            Console.WriteLine($"Square = {Squaree}, Perimeter = {Perimeterr}");
        }
    }
}
