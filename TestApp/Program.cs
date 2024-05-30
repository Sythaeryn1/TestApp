using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init");

            int answer = FirstFeature();
            Console.WriteLine($"Answer of the first feature: {answer}");

            answer = SecondFeature(answer);

            Console.WriteLine($"Answer of the second feature: {answer}");

            double ans = ThirdFeature();

            Console.WriteLine($"Answer 3: {ans}");

            int a = FourthFeature(ans);

            Console.WriteLine($"Answer 4: {a}");

            int b = Fifth();

            Console.WriteLine($"Answer 5: {b}");

            Console.WriteLine($"Answer: {Seven()}");

            Console.ReadLine();
        }

        public static int FirstFeature()
        {
            Console.WriteLine("This is a new feature");

            int a = 7;
            int b = 8;


            return a + b;
        }

        public static int SecondFeature(int answerFirstFeature)
        {
            int divider = 3;

            return answerFirstFeature / divider;
        }

        public static double ThirdFeature()
        {
            int a = 2;
            int b = 7;

            double c = Convert.ToDouble(a);

            return Convert.ToDouble(b / c);
        }

        public static int FourthFeature(double a)
        {
            double b = a / ThirdFeature();
            return Convert.ToInt32(b);
        }

        public static int Fifth()
        {
            double a = ThirdFeature();
            int b = FourthFeature(a);

            b += 23;

            return b * 100;
        }

        public static int Seven()
        {
            return 6;
        }
    }
}
