using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]   
    public class Addition : IOperator
    {         
        public string OperatorName { get { return "+"; } }
        public string Hilfe { get { return "'+' addiert zwei Zahlen des Stacks"; } }
        public double Calculate(Stack<double> stack)
        {
            double ergebnis = stack.ElementAt(1) + stack.Pop();
            stack.Pop();
            return ergebnis;
        }
    }
}
