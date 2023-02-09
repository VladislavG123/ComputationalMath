namespace Assignment5cs.RuleSolvers;

public class SimpsonsOneThirdRuleSolver : BaseRuleSolver
{
    public static double Solve(Integral integral, int numberOfOrdinates)
    {
        var width = CalculateWidth(integral, numberOfOrdinates);

        // Array for storing value of f(x)
        var fx = new double[numberOfOrdinates + 1];

        // Calculating values of f(x)
        for (var i = 0; i <= numberOfOrdinates; i++)
        {
            fx[i] = integral.Function(integral.LowerLimit + i * width);
        }

        // Calculating result
        var result = 0d;
        for (var i = 0; i <= numberOfOrdinates; i++)
        {
            if (i == 0 || i == numberOfOrdinates) result += fx[i];
            else if (i % 2 != 0) result += 4 * fx[i];
            else result += 2 * fx[i];
        }

        return result * (width / 3);
    }
}