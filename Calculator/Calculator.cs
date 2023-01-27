namespace Calculator;

public class Calculator
{
    public int Add(int firstSummand, int secondSummand)
    {
        return firstSummand + secondSummand;
    }

    public int Subtract(int minuend, int subtrahend)
    {
        return minuend - subtrahend;
    }

    public int Multiply(int firstFactor, int secondFactor)
    {
        return firstFactor * secondFactor;
    }

    public (int Result, int Remainder) Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }

        var result = dividend / divisor;
        var remainder = dividend % divisor;
        return (result, remainder);
    }
}