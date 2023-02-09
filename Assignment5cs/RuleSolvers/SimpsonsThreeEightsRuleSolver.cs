namespace Assignment5cs.RuleSolvers;

public class SimpsonsThreeEightsRuleSolver : BaseRuleSolver
{
    public static double Solve(Integral integral, int numberOfOrdinates)
    {
        var width = CalculateWidth(integral, numberOfOrdinates);
        var sum = CalculateSum(integral);
        
        for (var i = 1 ; i < numberOfOrdinates ; i++)
            sum += i % 3 == 0
                ? 2 * integral.Function(integral.LowerLimit + i * width)
                : 3 * integral.Function(integral.LowerLimit + i * width);
        
        return 3 * width / 8 * sum ;
    }
}