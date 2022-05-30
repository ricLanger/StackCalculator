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
            if (stack.Peek() > stack.Count)
            {
                double ergebnis = 0;
                int x = (int)stack.Pop();
                for (int i = 0; i < x; i++)
                {
                    ergebnis += stack.Pop();
                }
                return ergebnis;
            }
            else
            {
                throw new ArgumentException($"Die gesuchte Summe darf nicht größer sein als die Länge des Stacks. Stacklänge: {stack.Count - 1}, Gesuchte Summe: {stack.Peek()}");
            }        
        }
    }
}
