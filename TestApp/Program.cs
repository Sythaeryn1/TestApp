﻿using System;
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

            Console.ReadLine();
        }

        public static int FirstFeature()
        {
            Console.WriteLine("This is a new feature");

            int a = 7;
            int b = 8;


            return a + b;
        }
    }
}
