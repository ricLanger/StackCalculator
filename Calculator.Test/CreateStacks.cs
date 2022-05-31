using NUnit.Framework;
using FluentAssertions;
using Calculator.Library;
using System;
using System.Collections.Generic;

namespace Calculator.Test
{
    [TestFixture]
    public class CreateStacks
    {
        //static Stack<double> stack = new Stack<double>();    
        public static Stack<double> CreateSimpleStack()
        {
            Stack<double> stack = new ();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            return stack;
        }
        protected Stack<double> CreateEmptyStack()
        {
            return new Stack<double>();
        }
        protected Stack<double> CreateOneItemStack()
        {
            Stack<double> stack = new();
            stack.Push(1);
            return stack;
        }





        

    }
}
