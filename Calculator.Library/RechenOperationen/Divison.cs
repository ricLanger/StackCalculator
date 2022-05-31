using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    public class Divison : IOperator
    {
        public string OperatorName => "/";

        public string Hilfe => "'/' dividiert die obersten eiden Zahlen des Stacks";

        public double Calculate(Stack<double> stack)
        {
            if (stack.Peek() != 0)
            {
                double ergebnis = stack.ElementAt(1) / stack.Pop();
                stack.Pop();
                return ergebnis;
            }
            else throw new ArgumentException("Es darf nicht durch 0 geteilt werden!");
        }

        public void CalculateConditions(Stack<double> stack)
        {
            throw new NotImplementedException();
        }
    }
}
