using Assignment5cs.RuleSolvers;

namespace Assignment5cs.Tasks;

public class Task2
{
    public static void Run()
    {
        var integral1 = new Integral(
            0, 
            Math.PI, 
            Math.Sin
        );

        Console.WriteLine($"[Task2] Simpson's 1/3 Rule | " +
                          $"Result: {SimpsonsOneThirdRuleSolver.Solve(integral1, 11)}");
        
        var integral2 = new Integral(
            0, 
            Math.PI / 2, 
            x => Math.Sqrt(Math.Cos(x))
        );

        Console.WriteLine($"[Task2] Simpson's 1/3 Rule | " +
                          $"Result: {SimpsonsOneThirdRuleSolver.Solve(integral2, 9)}");
    }
}