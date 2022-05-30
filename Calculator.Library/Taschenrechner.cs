using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Calculator.Library.RechenOperationen;

namespace Calculator.Library
{
    public class Taschenrechner
    {

        internal Dictionary<string, IOperator> operators = new Dictionary<string, IOperator>();

        public void Starten()
        {
            Stack<double> stack = new();

            InitializeOperations();

            var input = "";

            while (true)
            {
                StackAnzeigen(stack);

                input = InputEingeben();

                double zahl;
                if (!Exit(input))
                {
                    if (double.TryParse(input, out zahl))
                    {
                        stack.Push(zahl);
                    }
                    else
                    {
                        PushAndRound(RechenoperationDurchführen(input, stack), stack);
                    }
                }
                else break;

            }
        }

        private void InitializeOperations()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<OperationClassAttribute>().Count() > 0);

            foreach (var type in types)
            {
                IOperator op = (IOperator)Activator.CreateInstance(type);
                operators.Add(op.OperatorName, op);
            }
        }

        public bool Exit(string input)
        {
            if (input.ToLower() == "exit")
            {
                return true;
            }
            else return false;
        }

        private double RechenoperationDurchführen(string input, Stack<double> stack)
        {
            var operation = operators[input];
            return operation.Calculate(stack);
        }

        private void PushAndRound(double zahl, Stack<double> stack)
        {
            stack.Push(Math.Round(zahl, 4));

        }

        private void StackAnzeigen(Stack<double> stack)
        {
            stack.ToArray();

            Console.Write("Stack: ");
            Console.WriteLine("[" + string.Join("|", stack) + "]");

        }

        private string InputEingeben()
        {
            Console.Write("Eingabe: ");
            var input = Console.ReadLine();
            return input;
        }
    }
}
;