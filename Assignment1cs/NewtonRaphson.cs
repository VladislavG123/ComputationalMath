using Assignment1cs.Abstract;

namespace Assignment1cs;

public class NewtonRaphson : Algorithm
{
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
    
    protected override double DoSection(double d, double d1, Func<double, double> func, int iteration = 0)
    {
        throw new NotImplementedException();
    }
}