namespace Calculator.Library.RechenOperationen
{
    public interface IOperator
    {
        public string OperatorName { get; }
        public string Hilfe { get; }
        public double Calculate(Stack<double> stack);
        public void CalculateConditions (Stack<double> stack);
    }
}
