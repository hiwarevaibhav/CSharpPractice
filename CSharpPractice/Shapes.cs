using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Shapes
    {
        
        public void AreaOfSquare(double side)
        {
            Console.WriteLine("Area of Square is : " + (side * side));
        }

        static void AreaOfCircle(double radius)
        {
            double pi = 3.14;
            Console.WriteLine("Area of Circle is : " + (pi * radius * radius));
        }

        static void AreaOfReactangle()
        {
            double length = 1.5;
            double breath = 5.3;
            double area = length * breath;

            Console.WriteLine("Area of Reactangle is : " + area);
        }

        static double AreaOfTriangle()
        {
            double half = 0.5;
            double b = 3.6;
            double h = 5.4;
            double area = half * b * h;
            return area;
        }

        //static void Main(String[] args)
        //{
        //    double areaOfTriangle = AreaOfTriangle();
        //    Console.WriteLine("Area of Triangle is : " + areaOfTriangle);

        //    Console.WriteLine("Area of Triangle is : " + AreaOfTriangle());
        //    Shapes.AreaOfCircle(8.1);
        //    AreaOfReactangle();
        //    AreaOfCircle(5.1);
        //    AreaOfCircle(6.71);
        //    AreaOfCircle(3.5);
        //    AreaOfCircle(2.9);
        //    AreaOfCircle(11);

        //    Shapes shape = new Shapes();
        //    shape.AreaOfSquare(7.1);
        //}
    }

    
}
