using Assignment5cs.RuleSolvers;

namespace Assignment5cs.Tasks;

public class Task3
{
    public static void Run()
    {
        var integral1 = new Integral(
            0, 
            9, 
            x => 1 / (1 + Math.Pow(x, 3))
        );

        Console.WriteLine($"[Task3] Simpson's 3/8 Rule | " +
                          $"Result: {SimpsonsThreeEightsRuleSolver.Solve(integral1, 10)}");
        
        var integral2 = new Integral(
            0, 
            Math.PI / 2, 
            Math.Sin
        );

        Console.WriteLine($"[Task3] Simpson's 3/8 Rule | " +
                          $"Result: {SimpsonsThreeEightsRuleSolver.Solve(integral2, 10)}");
    }
}