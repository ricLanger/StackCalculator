using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Bedingungen
    {
        public void CheckObStackGrößerEinsIst(Stack<double> stack)
        {
            if (stack.Count <= 1)
                throw new ArgumentException("Stack.Count muss größer 1 sein");
        }
        public void CheckObStackGrößerNullIst(Stack<double> stack)
        {
            if (stack.Count <= 0)
                throw new ArgumentException("Stack.Count muss größer 0 sein");
        }
    }
}
