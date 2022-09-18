using System;

namespace Mindbox
{
    public static class Figure
    {
        public enum Figures
        {
            Круг = 1, Треугольник
        }
        public static double Calculate(Figures figure)
        {
            switch (figure)
            {
                case Figures.Круг:
                    return CalculateCircle();
                case Figures.Треугольник:
                    return CalculateTriangle();
                default:
                    break;
            }
            return 0;
        }
        public static double CalculateTriangle()
        {
            double A, B, C, p, S;
            Console.WriteLine("Введите сторону A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону B: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону C: ");
            C = Convert.ToDouble(Console.ReadLine());

            p = (A + B + C) / 2;

            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return S;
        }
        public static double CalculateCircle()
        {
            Console.WriteLine("Введите радиус круга");
            double R = Convert.ToDouble(Console.ReadLine());
            return (Math.PI * R * R);
        }
    }
}
