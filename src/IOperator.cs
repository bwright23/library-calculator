namespace Calculator.Logic
{
    public interface IOperator
    {
        double Results {get;set;}

        double Calculate(double number1, double number2); 
    }

}