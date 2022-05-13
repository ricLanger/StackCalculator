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
                PushAndRound(zahl);
            }
            else if (Guards.OpGuard(input, rechner))
            {
                PushAndRound(RechenoperationEingeben(input));
            }

            Starten();
        }



        private static double RechenoperationEingeben(string input)
        {
            if (Guards.StackRangeGuard(rechner, input))
            {

                switch (input)
                {
                    case "+": return Rechenoperationen.Addition(rechner.Pop(), rechner.Pop());
                    case "-": return Rechenoperationen.Subtraktion(rechner.Pop(), rechner.Pop());
                    case "*": return Rechenoperationen.Multiplikation(rechner.Pop(), rechner.Pop());
                    case "/": return Rechenoperationen.Division(rechner.Pop(), rechner.Pop());

                    case "^": return Rechenoperationen.Potenzierung(rechner.Pop(), rechner.Pop());
                    case "sum": return Rechenoperationen.SummeXElemente((int)rechner.Pop());
                    case "avg": return Rechenoperationen.ArithmetischesMittel((int)rechner.Pop());
                    default: return rechner.Pop();
                }
            }
            else
            {
                switch (input)
                {
                    case "^2": return Rechenoperationen.Quadrat(rechner.Pop());
                    case "sqrt": return Rechenoperationen.Quadratwurzel(rechner.Pop());
                    default: return rechner.Pop();
                }
            }
           

        }

        private static void PushAndRound(double zahl)
        {
            rechner.Push(Math.Round(zahl, 4));
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
