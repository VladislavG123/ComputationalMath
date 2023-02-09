using Assignment5cs.RuleSolvers;

namespace Assignment5cs.Tasks;

public class Task1
{
    public static void Run()
    {
        var integral = new Integral(
            0, 
            1, 
            x => Math.Pow(x, 3)
            );

        Console.WriteLine($"[Task1] Trapezoidal Rule | " +
                          $"Result: {TrapezoidalRuleSolver.Solve(integral, 5)}");
    }
}