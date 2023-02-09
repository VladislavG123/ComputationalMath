namespace Assignment5cs.RuleSolvers;

public class TrapezoidalRuleSolver : BaseRuleSolver
{
    public static double Solve(Integral integral, int numberOfOrdinates)
    {
        var width = CalculateWidth(integral, numberOfOrdinates);
        var sum = CalculateSum(integral);
     
        // Adding middle terms in above formula
        for (var i = 1; i < numberOfOrdinates; i++)
            sum += 2 * integral.Function(integral.LowerLimit + i * width);
     
        return width / 2 * sum;
    }
}