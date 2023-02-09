namespace Assignment5cs.RuleSolvers;

public abstract class BaseRuleSolver
{
    /// <summary>
    /// Computing sum of first and last terms in above formula
    /// </summary>
    protected static double CalculateSum(Integral integral)
        => integral.Function(integral.LowerLimit) + integral.Function(integral.UpperLimit);
    
    protected static double CalculateWidth(Integral integral, int numberOfOrdinates)
        => (integral.UpperLimit - integral.LowerLimit) / numberOfOrdinates;
}