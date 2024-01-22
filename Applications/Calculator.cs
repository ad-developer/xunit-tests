namespace Applications;
public class Calculator
{
    private  int _timesUsed; 
    public Calculator()
    {
        _timesUsed = 0;
    }

    public decimal Add(decimal x, decimal y)
    {
        _timesUsed++;
        return x + y;
    }

    public decimal Substract(decimal x, decimal y)
    {
        _timesUsed++;
        return x - y;
    }

    public decimal Multiply(decimal x, decimal y)
    {
        _timesUsed++;
        return x * y;
    }

    public decimal Divide(decimal x, decimal y)
    {
        _timesUsed++;
        return x / y;
    }

    public int HowManyTimesCalculatorUsed()
    {
        return _timesUsed;
    }
}


