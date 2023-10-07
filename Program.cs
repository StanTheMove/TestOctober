using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть кількість точок N:");
            int N = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Введіть координати точки {i} (x y):");
                string[] input = Console.ReadLine().Split(' ');
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                points.Add(new Point(x, y));
            }

            double maxPerimeter = 0;
            List<Point> maxPerimeterVertices = new List<Point>();

            // Перебираємо всі можливі комбінації трьох точок
            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        double side1 = Distance(points[i], points[j]);
                        double side2 = Distance(points[j], points[k]);
                        double side3 = Distance(points[k], points[i]);
                        double perimeter = side1 + side2 + side3;

                        if (perimeter > maxPerimeter)
                        {
                            maxPerimeter = perimeter;
                            maxPerimeterVertices = new List<Point> { points[i], points[j], points[k] };
                        }
                    }
                }
            }

            Console.WriteLine($"Найбільший периметр: {maxPerimeter}");
            Console.WriteLine("Вершини треугольника:");
            foreach (var vertex in maxPerimeterVertices)
            {
                Console.WriteLine($"({vertex.X}, {vertex.Y})");
            }
        }

        static double Distance(Point p1, Point p2)
        {
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}