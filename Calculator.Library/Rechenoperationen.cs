using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class Rechenoperationen
    {
        
        public static List<string> op = new List<string> 
                        { "+", "-", "*", "/", "^2", "sqrt", "^", "sum", "avg" };
        public static double Addition(double x, double y) => x + y;
        public static double Subtraktion(double x, double y) => x - y;
        public static double Multiplikation(double x, double y) => x * y;
        public static double Division(double x, double y)
        {
            if (Guards.DivisionGuard(y)) return x / y;
            else { Taschenrechner.rechner.Push(y); return x; }
        }
        public static double Quadrat(double x) => Math.Pow(x, 2);
        public static double Quadratwurzel(double x)
        {
            if (Guards.SqrtGuard(x)) return Math.Sqrt(x);
            else return x;
        }
        public static double Potenzierung(double x, double y) => Math.Pow(x, y);
        public static double SummeXElemente(int x, Stack<double> stack)
        {
            if (Guards.SumGuard(x, stack))
            {
                double ergbnis = 0;

                for (int i = 0; i < x; i++)
                {
                    ergbnis += stack.Pop();
                }
                return ergbnis;
            }
            else { return x; }
        }
        public static double ArithmetischesMittel(int x)
        {
            if (Guards.AvgGuard(x, Taschenrechner.rechner))
            {
                double temp = 0;
                for (int i = 0; i < x; i++)
                {
                    temp += Taschenrechner.rechner.Pop();
                }
                return temp / x;
            }
            else { return x; }

        }


    }
}
