using System;
using System.Collections.Generic;
using System.Linq;
using Mindbox;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фигуру для расчёта");
            for (int i = 0; i <= GetEnumList<Figure.Figures>().Count - 1; i++)
            {
                Console.WriteLine((i +1) +". " + GetEnumList<Figure.Figures>()[i]);
            }
            Console.WriteLine("Площадь составила: " + Figure.Calculate((Figure.Figures)Int32.Parse(Console.ReadLine())));
            Console.ReadLine();
        }
        private static List<T> GetEnumList<T>()
        {
            T[] array = (T[])Enum.GetValues(typeof(T));
            List<T> list = new List<T>(array);
            return list;
        }
    }
}
