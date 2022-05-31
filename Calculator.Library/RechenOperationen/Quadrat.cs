using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    public class Quadrat : IOperator
    {
        public string OperatorName => "^2";

        public string Hilfe => "'^2' quadriert die oberste Zahl des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CalculateConditions(stack);

            return Math.Pow(stack.Pop(), 2);
        }
        private void CalculateConditions(Stack<double> stack)
        {
            if (stack.Count < 0)
            {
                throw new ArgumentException("Stackgröße darf nicht leer sein!");
            }
        }
    }
}
