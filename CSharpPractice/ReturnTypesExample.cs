using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class ReturnTypesExample
    {
        //static void Main(String[] args)
        //{
        //    //square of a number is odd or even?
        //    //n*n
        //    //n/2
            
        //    double number = 4.0;
        //    double squareOfANumber = SquareOfANumber(number);
        //    double area = AreaOfReactangle();

        //    double remainder = ModulasOfANumber(squareOfANumber);

        //    if (remainder.Equals(1))
        //    {
        //        Console.WriteLine("Sqauare of a Number " + number + " is Odd number");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sqauare of a Number " + number + " is Even number");
        //    }
        //}

        public static string MethodName1()
        {
            return "hello";
        }

        static double SquareOfANumber(double number)
        {
            double a = number * number;
            return a;
        }

        static double ModulasOfANumber(double number)
        {
            double mod = number % 2;
            return mod;
        }

        public static double AreaOfReactangle()
        {
            double length = 3.1;
            double width = 4.7;
            double area = length * width;
            Console.WriteLine("Area of Rectangle is : " + area);
            return area;
        }
    }
}
