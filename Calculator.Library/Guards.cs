//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calculator.Library
//{
//    public class Guards
//    {

//        public static bool OpGuard(string input, Stack<double> stack)
//        {
//            if (input.Length == 0)
//            {
//                Console.WriteLine("Ihr Input darf nicht leer sein!");
//                return false;
//            }
//            if (stack.Count == 0)
//            {
//                Console.WriteLine("Stack darf nicht leer sein!");
//                return false;
//            }
//            if (!Rechenoperationen.op.Contains(input))
//            {
//                Console.WriteLine($"Ungültige Angabe.Ihre Rechenoperations Angabe muss eine der folgenden Angaben beinhalten: { string.Join(',', Rechenoperationen.op)}");
//                return false;
//            }
//            return true;
//        }
        
//        public static bool StackRangeGuard( string input, Stack<double> stack)
//        {
//            if(stack.Count < 2 && input != "sqrt" && input != "^2")
//            {
//                Console.WriteLine($"Für diese Operationen müssen min. 2 Zahlen im Stack vorhanden sein. Stacklänge: {stack.Count}");
                
//                return false;
                
//            }
//            if(stack.Count >=2 && input != "sqrt" && input != "^2")
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}











//public static bool AvgGuard(int x, Stack<double> stack)
//{
//    if (stack.Count < x)
//    {
//        Console.WriteLine($"Der gesuchte Mittelwert darf nicht größer sein als die Länge des Stacks. Stacklänge: {stack.Count}, Gesuchte Summe: {x}");
//        return false;
//    }
//    return true;
//}

//public static bool DivisionGuard(double x) 
//{
//    if (x == 0)
//    {
//        Console.WriteLine($"Der Parameter darf nicht Null sein.Er war {x}");
//        return false;
//    }
//    return true;           
//}

//public static bool SqrtGuard(double x)
//{
//    if (x < 0)
//    {
//        Console.WriteLine($"Der Parameter darf nicht kleiner Null sein. Er war {x}");
//        return false;
//    }
//    return true;           
//}

//public static bool SumGuard(int x, Stack<double> stack)
//{
//    if (stack.Count < x)
//    {
//        Console.WriteLine($"Die gesuchte Summe darf nicht größer sein als die Länge des Stacks. Stacklänge: {stack.Count}, Gesuchte Summe: {x}");
//        return false;
//    }
//    return true;            
//}
