namespace Assignment3cs.Tasks;

public class Task2 : TaskBase
{
    public override void Solve()
    {
        var text = "Function: y = a + bx";
        Console.WriteLine(text);
        
        var xValues = new[] { 6.0, 7, 7, 8, 8, 8, 9, 9, 10};
        var yValues = new[] { 5.0, 5, 4, 5, 4, 3, 4, 3, 3};

        var (a, b) = LeastSquareRegressionLineSolver.LeastRegressionLine(xValues, yValues);
        Console.WriteLine(text
            .Replace("a", a.ToString())
            .Replace("b", b.ToString()));
    }
}