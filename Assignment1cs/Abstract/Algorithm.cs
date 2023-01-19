namespace Assignment1cs.Abstract;

public abstract class Algorithm
{
    protected const double Tolerance = 0.0001;
    public double Run((double, double, Func<double, double>) arg) => Run(arg.Item1, arg.Item2, arg.Item3);
    public virtual double Run(double a, double b, Func<double, double> func)
    {
        if (func(a) * func(b) >= 0)
            throw new ArgumentException("f(a) * f(b) must be < 0");
        
        return DoSection(a, b, func);
    }

    protected abstract double DoSection(double d, double d1, Func<double, double> func, int iteration = 0);

}