using System.Diagnostics.CodeAnalysis;

namespace Assignment1cs;

public class Bisection : Algorithm
{
    public static (double, double, Func<double, double>)[] TestCases => new (double, double, Func<double, double>)[]
    {
        (10.9, 0.9, x => (x * x * x) - x - 1.0), 
        (2, -2, x => x - Math.Cos(x)),
        (2, 0, x => Math.Exp(-x) - x)
    };
    
    
    protected override double DoSection(double a, double b, Func<double, double> func, int iteration = 0)
    {
        var c = (a + b) / 2.0;
        if (++iteration >= 1000) return c;
        
        return func(c) switch
        {
            >= -0.001 and <= 0.001 => c,
            _ when func(a) * func(c) < 0 => DoSection(c, b, func, iteration),
            _  => DoSection(a, c, func, iteration),
        };
    }
}

