using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    internal class Potenzierung : IOperator
    {
        public string OperatorName => "^";

        public string Hilfe => "'^' potenziert mit der obersten Zahl als Basis und der zweiten als Exponent";

        public double Calculate(Stack<double> stack)
        {
            double ergebnis = Math.Pow(stack.ElementAt(1), stack.Pop());
            stack.Pop();
            return ergebnis;
        }
    }
}
