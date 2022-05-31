using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    public class Multiplikation : IOperator
    {
        public string OperatorName => "*";

        public string Hilfe => "'*' multipliziert die obersten beiden Zahlen des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CalculateConditions(stack);

            double ergebnis = stack.ElementAt(1) * stack.Pop();
            stack.Pop();
            return ergebnis;
        }

        public void CalculateConditions(Stack<double> stack)
        {
            if (stack.Count < 1)
            {
                throw new ArgumentException("Stackgröße darf nicht kleiner gleich 1 sein!");
            }
        }
    }
}
