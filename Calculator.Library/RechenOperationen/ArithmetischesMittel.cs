using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class ArithmetischesMittel : Bedingungen, IOperator
    {
        public string OperatorName => "avg";

        public string Hilfe => "'avg' arithmetisches Mittel der obersten x Elemnete des Stacks";

        public double Calculate(Stack<double> stack)
        {
            CheckObStackGrößerEinsIst(stack);

            double temp = 0;
            int x = (int)stack.Pop();
            for (int i = 0; i < x; i++)
            {
                temp += stack.Pop();
            }
            return temp / x;
        }
    }
    }
