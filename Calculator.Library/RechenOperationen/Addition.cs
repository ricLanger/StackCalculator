using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Addition : Bedingungen, IOperator
    {
        public string OperatorName { get { return "+"; } }
        public string Hilfe { get { return "'+' addiert zwei Zahlen des Stacks"; } }
        public double Calculate(Stack<double> stack)
        {
            CheckObStackGrößerEinsIst(stack);

            return stack.Pop() + stack.Pop();
        }
    }
}
