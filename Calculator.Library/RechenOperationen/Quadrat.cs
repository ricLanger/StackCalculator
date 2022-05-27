using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Quadrat : Bedingungen, IOperator
    {
        public string OperatorName => "^2";

        public string Hilfe => "'^2' quadriert die oberste Zahl des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CheckObStackGrößerNullIst(stack);

            return Math.Pow(stack.Pop(), 2);
        }
    }
}
