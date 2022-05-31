using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    [OperationClass]
    internal class ArithmetischesMittel : IOperator
    {
        public string OperatorName => "avg";

        public string Hilfe => "'avg' arithmetisches Mittel der obersten x Elemnete des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CalculateConditions(stack);

            double temp = 0;
            int x = (int)stack.Pop();
            for (int i = 0; i < x; i++)
            {
                temp += stack.Pop();
            }
            return temp / x;
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
