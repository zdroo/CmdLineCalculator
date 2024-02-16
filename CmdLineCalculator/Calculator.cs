using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdLineCalculator
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Substract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x*y;
        }
        public static double Divide(double x, double y)
        {
            if (y != 0.0)
                return x / y;
            else return 0;
        }
        public static double PowerRaise(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
