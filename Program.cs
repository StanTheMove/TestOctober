using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NigrNegr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Integer26();
            Boolean38();
            If13();
            For12();
            For24();
            While10();
        }
        static void Integer26()
        {
            int dayOfYear = int.Parse(Console.ReadLine());

            int dayOfWeek = GetDayOfWeek(dayOfYear);
        }
        static int GetDayOfWeek(int dayOfYear)
        {
            int firstDayOfWeek = 2;
            int dayOfWeek = (firstDayOfWeek + (dayOfYear - 1)) % 7;

            if (dayOfWeek == 0)
            {
                dayOfWeek = 7;
            }

            return dayOfWeek;
        }
        static void Boolean38()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            bool canBishopMove = CanBishopMove(x1, x2, y1, y2);

            if (canBishopMove)
            {
                Console.WriteLine("Слон може ходити");
            }
            else
            {
                Console.WriteLine("Слон не може ходити");
            }
        }
        static bool CanBishopMove(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        }
        static void If13()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double middleNumber = FindMiddleNumber(a, b, c);
        }
        static double FindMiddleNumber(double a, double b, double c)
        {
            double min = Math.Min(Math.Min(a, b), c);
            double max = Math.Max(Math.Max(a, b), c);

            double middleNumber = (a + b + c) - (min + max);

            return middleNumber;
        }
        static void For12()
        {
            int N = int.Parse(Console.ReadLine());

            if (N > 0)
            {
                double product = CalculateProduct(N);
            }
        }
        static double CalculateProduct(int N)
        {
            double product = 1.0;

            for (int i = 1; i <= N; i++)
            {
                double multiplier = 1.0 + (0.1 * i);
                product *= multiplier;
            }

            return product;
        }
        static void For24()
        {
            double X = double.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());

            double result = CalculateCosineApproximation(X, N);
        }
        static double CalculateCosineApproximation(double X, int N)
        {
            double cosApproximation = 0.0;
            for (int i = 0; i <= N; i++)
            {
                double term = Math.Pow(-1, i) * Math.Pow(X, 2 * i) / Factorial(2 * i);
                cosApproximation += term;
            }
            return cosApproximation;
        }
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            double result = 1.0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static void While10()
        {
            int N = int.Parse(Console.ReadLine());

            if (N > 1)
            {
                int K = FindLargestK(N);
            }
        }

        static int FindLargestK(int N)
        {
            return N / 3;
        }
    }
}
