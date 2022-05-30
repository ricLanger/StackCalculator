using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    internal class Addition : IOperator
    {  
        
        public string OperatorName { get { return "+"; } }
        public string Hilfe { get { return "'+' addiert zwei Zahlen des Stacks"; } }
        public double Calculate(Stack<double> stack)
        {
            return stack.Pop() + stack.Pop();
        }
    }
}
