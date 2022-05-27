﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.RechenOperationen
{
    internal class Potenzierung : IOperator
    {
        public string OperatorName => "^";

        public string Hilfe => "'^' potenziert mit der obersten Zahl als Basis und der zweiten als Exponent";

        public double Calculate(Stack<double> stack)
        {
            return Math.Pow(stack.Pop(), stack.Pop());
        }
    }
}