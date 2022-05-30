using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Subtraktion : IOperator
    {
        public string OperatorName => "-";

        public string Hilfe { get { return "'-' subtrahiert zwei Zahlen des Stacks"; } }

        public double Calculate(Stack<double> stack)
        {
            return stack.Pop() - stack.Pop();
        }
    }
}
