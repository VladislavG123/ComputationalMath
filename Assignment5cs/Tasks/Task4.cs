using Assignment5cs.RuleSolvers;

namespace Assignment5cs.Tasks;

public class Task4
{
    public static void Run()
    {
        var numberOfOrdinates = 10;
        var integral = new Integral(
            0, 
            1, 
            x => 1.0 / (1 + x)
        );

        Console.WriteLine($"[Task4] Trapezoidal Rule | " +
                          $"Result: {TrapezoidalRuleSolver.Solve(integral, numberOfOrdinates)}");
        
        Console.WriteLine($"[Task4] Simpson's 1/3 Rule | " +
                          $"Result: {SimpsonsOneThirdRuleSolver.Solve(integral, numberOfOrdinates)}");
        
        Console.WriteLine($"[Task4] Simpson's 3/8 Rule | " +
                          $"Result: {SimpsonsThreeEightsRuleSolver.Solve(integral, numberOfOrdinates)}");
    }
}