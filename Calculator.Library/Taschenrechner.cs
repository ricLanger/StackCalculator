using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class Taschenrechner
    {
        public static Stack<double> rechner = new Stack<double>();

        public static void Starten()
        {
            StackAnzeigen();


            var input = Console.ReadLine();

            double zahl;

            if (double.TryParse(input, out zahl))
            {
                PushAndRound(zahl, rechner);
            }
            else if (Guards.OpGuard(input, rechner))
            {
                PushAndRound(RechenoperationEingeben(input, rechner), rechner);
            }

            Starten();
        }

        public static double RechenoperationEingeben(string input, Stack<double> stack)
        {
            if (Guards.StackRangeGuard(input, stack))
            {
                switch (input)
                {
                    case "+": return Rechenoperationen.Addition(stack.Pop(), stack.Pop());
                    case "-": return Rechenoperationen.Subtraktion(stack.Pop(), stack.Pop());
                    case "*": return Rechenoperationen.Multiplikation(stack.Pop(), stack.Pop());
                    case "/": return Rechenoperationen.Division(stack.Pop(), stack.Pop());

                    case "^": return Rechenoperationen.Potenzierung(stack.Pop(), stack.Pop());
                    case "sum": return Rechenoperationen.SummeXElemente((int)stack.Pop(),stack);
                    case "avg": return Rechenoperationen.ArithmetischesMittel((int)stack.Pop(), stack);
                    default: return stack.Pop();
                }
            }
            else
            {
                switch (input)
                {
                    case "^2": return Rechenoperationen.Quadrat(stack.Pop());
                    case "sqrt": return Rechenoperationen.Quadratwurzel(stack.Pop());
                    default: return stack.Pop();
                }
            }
            
        }

        public static void PushAndRound(double zahl, Stack<double> stack)
        {
            stack.Push(Math.Round(zahl, 4));
            
        }

        private static void StackAnzeigen()
        {
            rechner.ToArray();

            Console.Write("Stack: ");
            Console.WriteLine("[" + string.Join("|", rechner) + "]");
            Console.Write("Eingabe: ");
        }
    }
}
