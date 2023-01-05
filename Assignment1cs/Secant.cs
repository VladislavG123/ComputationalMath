namespace Assignment1cs;

public class Secant : Algorithm
{
    public static (double, double, Func<double, double>)[] TestCases => new (double, double, Func<double, double>)[]
    {
        (1, -1, x => x - Math.Exp(-x)), 
        (20, -20, x => (x * x * x) + (x * x) + x + 7)
    };
    
    public override double Run(double x0, double x1, Func<double, double> func)
    {
        if (x1 >= x0)
            throw new ArgumentException("x1 >= x0");

        return base.Run(x0, x1, func);
    }

    protected override double DoSection(double x0, double x1, Func<double, double> func, int iteration = 0)
    {
        var x2 = x1 * func(x1) * (x1 - x0) / (func(x1) - func(x0));

        if ((x2 - x1) / x2 > Tolerance && ++iteration < 1000)
        {
            DoSection(x1, x2, func, iteration);
        }

        return x2;
    }
}