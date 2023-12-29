using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //расчет параметров окружности
            Console.Write("Введите длину окружности ");
            double length=Convert.ToDouble(Console.ReadLine());
            double radius = length / (2*Math.PI);
            Console.WriteLine("Радиус окружности= " + radius);

            //расчет параметров прямоугольника
            Console.Write("Введите координату x1 первой вершины прямоугольника ");
            double x1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y1 первой вершины прямоугольника ");
            double y1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x2 второй вершины прямоугольника ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y2 второй вершины прямоугольника ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double per = 2 * ((x2 - x1) + (y2 - y1));
            double square=(x2-x1)*(y2-y1);
            Console.WriteLine("Периметр прямоугольника= "+per+", Площадь прямоугольника= "+square) ;


            //расчет параметров треугольника
            Console.Write("Введите координату x1 первой вершины треугольника ");
             x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y1 первой вершины треугольника ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x2 второй вершины треугольника ");
             x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y2 второй вершины треугольника ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x3 третьей вершины треугольника ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y3 третьей вершины треугольника ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double ab = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            double bc = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double ca = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            per=ab+bc+ca;
            square = Math.Sqrt((per / 2) * ((per / 2) - ab) * ((per / 2) - bc) * ((per / 2) - ca));
            Console.WriteLine("Периметр треугольника=" + per + ", Площадь треугольника=" + square);


            Console.ReadKey();


        }
    }
}
