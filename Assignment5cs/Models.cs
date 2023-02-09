namespace Assignment5cs;

public class Integral
{
    public Integral(double lowerLimit, double upperLimit, Func<double, double> function)
    {
        LowerLimit = lowerLimit;
        UpperLimit = upperLimit;
        Function = function;
    }

    public double LowerLimit { get; set; }
    public double UpperLimit { get; set; }
    public Func<double, double> Function { get; set; }
}