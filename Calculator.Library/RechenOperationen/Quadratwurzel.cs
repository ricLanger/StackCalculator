using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Quadratwurzel : IOperator
    {
        public string OperatorName => "sqrt";

        public string Hilfe => "'sqrt' zieht die Wurzel der obersten Zahl des Stacks";

        public double Calculate(Stack<double> stack)
        {
            if (stack.Peek() >= 0)
                return Math.Sqrt(stack.Pop());
            else throw new ArgumentException("Nicht durch eine negative Zahl die Wurzel ziehen");
        }
    }
}
