namespace Assignment1cs;

public class Iteration : Algorithm
{
    private const double DefaultX = 1;

    public static (double, double, Func<double, double>)[] TestCases => new (double, double, Func<double, double>)[]
    {
        (10.9, 0.9, x => (x * x * x) - (9 * x) + 1), 
        (2, -2, x => x - 0.3 - Math.Sin(x)),
        (2, 0, x => Math.Exp(x) - 5 * x)
    };
    
    public virtual double Run(double a, double b, Func<double, double> func)
    {
        if (func(a) * func(b) >= 0)
            throw new ArgumentException("f(a) * f(b) must be < 0");
        
        return DoSection(a, b, func);
    }
    
    protected override double DoSection(double a, double b, Func<double, double> func, int iteration = 0)
    {
        var x = func(DefaultX);

        return DoSection(a, b, func, x, iteration);
    }
    
    private double DoSection(double a, double b, Func<double, double> func, double x, int iteration = 0)
    {
        var c = (a + b) / 2.0;
        var x0 = x >= a && x <= b && Math.Abs(x - c) < Tolerance ? a : b;
        var x1 = func(x0);
        
        if (++iteration >= 1000) return x1;

        if (Math.Abs(func(x1) - func(x0)) < Tolerance)
        {
            return x1;
        }

        return DoSection(a, b, func, x1, iteration);
    }
}