//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calculator.Library
//{
//    public class Rechenoperationen
//    {

//        public static List<string> op = new List<string>
//                        { "+", "-", "*", "/", "^2", "sqrt", "^", "sum", "avg" };
//        public static double Addition(double x, double y) => x + y;
//        public static double Subtraktion(double x, double y) => x - y;
//        public static double Multiplikation(double x, double y) => x * y;
//        public static double Division(double x, double y)
//        {
//            if (y == 0)
//            {
//                Console.WriteLine($"Der Parameter darf nicht Null sein.Er war {x}");
//                Taschenrechner.stack.Push(y);
//                return x;
//            }
//            return x / y;

//        }
//        public static double Quadrat(double x) => Math.Pow(x, 2);
//        public static double Quadratwurzel(double x)
//        {
//            if (x < 0)
//            {
//                Console.WriteLine($"Der Parameter darf nicht kleiner Null sein. Er war {x}");
//                return x;
//            }
//            return Math.Sqrt(x);

//        }
//        public static double Potenzierung(double x, double y) => Math.Pow(x, y);
//        public static double SummeXElemente(int x, Stack<double> stack)
//        {
//            if (stack.Count < x)
//            {
//                Console.WriteLine($"Die gesuchte Summe darf nicht größer sein als die Länge des Stacks. Stacklänge: {stack.Count}, Gesuchte Summe: {x}");
//                return x;
//            }
//            double ergbnis = 0;

//            for (int i = 0; i < x; i++)
//            {
//                ergbnis += stack.Pop();
//            }
//            return ergbnis;

//        }
//        public static double ArithmetischesMittel(int x, Stack<double> stack)
//        {
//            if (stack.Count < x)
//            {
//                Console.WriteLine($"Der gesuchte Mittelwert darf nicht größer sein als die Länge des Stacks. Stacklänge: {stack.Count}, Gesuchte Summe: {x}");
//                return x;
//            }

//            double temp = 0;
//            for (int i = 0; i < x; i++)
//            {
//                temp += stack.Pop();
//            }
//            return temp / x;


//        }


//    }
//}
