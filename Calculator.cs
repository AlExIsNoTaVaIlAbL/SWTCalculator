using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTCalculator
{
    public class Calculator
    {
            public Calculator()
            {}
     
            public double Add(double a, double b)
            { return a + b; }

            public double Subtract(double a, double b)
            { return a - b; }

            public double Mulitply(double a, double b)
            { return a * b; }

            public double Power(double a, double exp)
            { return Math.Pow(a, exp); }
    }

 }