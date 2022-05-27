using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Subtraktion :Bedingungen, IOperator
    {
        public string OperatorName => "-";

        public string Hilfe { get { return "'-' subtrahiert zwei Zahlen des Stacks"; } }

        public double Calculate(Stack<double> stack)
        {
            CheckObStackGrößerEinsIst(stack);

            return stack.Pop() - stack.Pop();
        }
    }
}
