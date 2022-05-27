using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Library.RechenOperationen;

namespace Calculator.Library
{
    public class Taschenrechner
    {
        
        internal static Dictionary<string, IOperator> operators = new Dictionary<string, IOperator>();

        private static Stack<double> stack = new Stack<double>();

        private static void InitializeOperations()
        {
            IOperator addition = new Addition();
            operators.Add(addition.OperatorName, addition);
            IOperator subtraktion = new Subtraktion();
            operators.Add(subtraktion.OperatorName, subtraktion);
            IOperator multipliaktion = new Multiplikation();
            operators.Add(multipliaktion.OperatorName, multipliaktion);
            IOperator divison = new Divison();
            operators.Add(divison.OperatorName, divison);
            IOperator quadrat = new Quadrat();
            operators.Add(quadrat.OperatorName, quadrat);
            IOperator potenzierung = new Potenzierung();
            operators.Add(potenzierung.OperatorName, potenzierung);
            IOperator summe = new Summe();
            operators.Add(summe.OperatorName, summe);
            IOperator arithmetischesMittel = new ArithmetischesMittel();
            operators.Add(arithmetischesMittel.OperatorName, arithmetischesMittel);
        }

        public static void Starten()
        {
            InitializeOperations();

            while (true) // Abbruchbedingung hinzufügen
            {
                StackAnzeigen();

                var input = InputEingeben() ;

                double zahl;

                if (double.TryParse(input, out zahl))
                {
                    stack.Push(zahl);
                }          
                else 
                {
                    PushAndRound(RechenoperationDurchführen(input, stack), stack);
                }           
            }
        }


        public static double RechenoperationDurchführen(string input, Stack<double> stack)
        {
            var operation = operators[input];
            return operation.Calculate(stack);
        }

        public static void PushAndRound(double zahl, Stack<double> stack)
        {
            stack.Push(Math.Round(zahl, 4));

        }

        private static void StackAnzeigen()
        {
            stack.ToArray();

            Console.Write("Stack: ");
            Console.WriteLine("[" + string.Join("|", stack) + "]");            
        }       
        private static string InputEingeben()
        {
            Console.Write("Eingabe: ");
            var input = Console.ReadLine();
            return input;
        }
    }
}
