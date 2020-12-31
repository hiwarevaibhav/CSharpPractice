using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class SimpleInterest
    {
        //static void Main(String[] args)
        //{
        //    DiameterOfCircle(5);

        //    //Simple interest

        //    CalculationOfFinalPrincipleAndSimpleInterest(1500.99, 8.1f, 5.2f);
        //    CalculationOfFinalPrincipleAndSimpleInterest(5500.99, 8.1f, 1.2f);
        //    CalculationOfFinalPrincipleAndSimpleInterest(7500, 8.1f, 3.2f);
        //    CalculationOfFinalPrincipleAndSimpleInterest(8900.99, 8.1f, 7.2f);
        //}

        static void CalculationOfFinalPrincipleAndSimpleInterest(double p, float interestRate, float time)
        {
            double amount;
            amount = p * (1 + (interestRate * time));

            Console.WriteLine("Final Amount post simple interest : " + amount);
        }

        static void DiameterOfCircle(double r)
        {
            double diameter = 2 * r;
            Console.WriteLine("Diameter of Circle is : " + diameter);

        }
    }
}
