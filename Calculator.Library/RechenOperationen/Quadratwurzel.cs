using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    internal class Quadratwurzel : IOperator
    {
        public string OperatorName => "sqrt";

        public string Hilfe => "'sqrt' zieht die Wurzel der obersten Zahl des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CalculateConditions(stack);
            return Math.Sqrt(stack.Pop());

        }

        public void CalculateConditions(Stack<double> stack)
        {
            if (stack.Count < 0)
            {
                throw new ArgumentException("Stackgröße darf nicht leer sein!");
            }
            if (stack.Peek() < 0)
            {
                throw new ArgumentException("Nicht durch eine negative Zahl die Wurzel ziehen");
            }
        }
    }
}
