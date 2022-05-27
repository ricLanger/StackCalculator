using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Multiplikation : Bedingungen, IOperator
    {
        public string OperatorName => "*";

        public string Hilfe => "'*' multipliziert die obersten beiden Zahlen des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CheckObStackGrößerEinsIst(stack);

            return stack.Pop() * stack.Pop();
        }
    }
}
