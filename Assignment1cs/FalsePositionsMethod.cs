namespace Assignment1cs;

public class FalsePositionsMethod : Algorithm
{
    public static (double, double, Func<double, double>)[] TestCases => new (double, double, Func<double, double>)[]
    {
        (10.9, 0.9, x => (x * x * x) - 5 * x + 1.0), 
        (2, -2, x => x * Math.Exp(x) - 2), 
        (2, -2, x => Math.Cos(x) - 3 * x + 1), 
        (7, 1, x => 2 * x - Math.Log2(x) - 7)
    };

    protected override double DoSection(double a, double b, Func<double, double> func, int iteration = 0)
    {
        var c = (a * func(b) - b * func(a)) / (func(b) - func(a));
        if (func(c) is >= -0.001 and <= 0.001 || ++iteration >= 1000) return c;

        return func(c) * func(a) < 0 ? DoSection(a, c, func, iteration) : DoSection(c, b, func, iteration);
    }
}
