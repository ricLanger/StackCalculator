using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    internal class Subtraktion : IOperator
    {

        public string OperatorName => "-";

        public string Hilfe { get { return "'-' subtrahiert zwei Zahlen des Stacks"; } }

        public double Calculate(Stack<double> stack)
        {           
            double ergebnis = stack.ElementAt(1) - stack.Pop();
            stack.Pop();
            return ergebnis;          
        }
    }
}
