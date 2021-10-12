using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника.");
            Console.WriteLine("Введите длину первой стороны треугольника.");
            double triangle_1_A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны треугольника.");
            double triangle_1_B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны треугольника.");
            double triangle_1_C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника.");
            Console.WriteLine("Введите длину первой стороны треугольника.");
            double triangle_2_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны треугольника.");
            double triangle_2_B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны треугольника.");
            double triangle_2_C = Convert.ToInt32(Console.ReadLine());

            int numBigger = WhichTriangleIsBigger(triangle_1_A, triangle_1_B, triangle_1_C, triangle_2_A, triangle_2_B, triangle_2_C);
            Console.WriteLine("Больше площадь треугольника № {0}.", numBigger);
            Console.ReadKey();
        }

        static int WhichTriangleIsBigger(double first_A, double first_B, double first_C, double second_A, double second_B, double second_C)
        {
            int num = 0;
            double first_halfPer = (first_A + first_B + first_C) / 2;
            double second_halfPer = (second_A + second_B + second_C) / 2;

            Console.WriteLine("Полупериметр первого: {0}.", first_halfPer);

            double first_area = Math.Sqrt(first_halfPer * (first_halfPer - first_A) * (first_halfPer - first_B) * (first_halfPer - first_C));
            double second_area = Math.Sqrt(second_halfPer * (second_halfPer - second_A) * (second_halfPer - second_B) * (second_halfPer - second_C));

            Console.WriteLine("Площадь первого треугольника: {0}.", first_area);
            Console.WriteLine("Площадь второго треугольника: {0}.", second_area);

            if (first_area > second_area)
            {
                num = 1;
            }
            else
            {
                num = 2;
            }
            return num;
        }
    }
}
