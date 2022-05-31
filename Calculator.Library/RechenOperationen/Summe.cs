using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    internal class Summe : IOperator
    {
        public string OperatorName => "sum";

        public string Hilfe => "'sum' summiert die obersten x Elemente des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CalculateConditions(stack);

            double ergebnis = 0;
            int x = (int)stack.Pop();
            for (int i = 0; i < x; i++)
            {
                ergebnis += stack.Pop();
            }
            return ergebnis;
        }
        public void CalculateConditions(Stack<double> stack)
        {
            if (stack.Count < 1)
            {
                throw new ArgumentException("Stackgröße darf nicht kleiner gleich 1 sein!");
            }
            if (stack.Peek() >= stack.Count)
            {
                throw new ArgumentException("Gesuchte Summe darf nicht größer gleich der Stackgröße sein!");
            }
        }
    }
}
