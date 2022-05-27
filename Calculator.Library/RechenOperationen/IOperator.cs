namespace Calculator.Library.RechenOperationen
{
    internal interface IOperator
    {
        public string OperatorName { get; }
        public string Hilfe { get; }
        public double Calculate(Stack<double> stack);
    }
}