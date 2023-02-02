namespace Assignment3cs.Tasks;

public class Task4 : TaskBase
{
    public override void Solve()
    {
        var text = "Function: y = ax + bx^2";
        Console.WriteLine(text);
        
        var xValues = new[] { 1.0, 2, 3, 4, 5};
        var yValues = new[] { 1.8, 5.1, 8.9, 14.1, 19.8};
        
        // Transform function to Y = a + bx, where Y = y/x
        yValues = Enumerable
            .Range(0, yValues.Length)
            .Select(i => yValues[i] / xValues[i])
            .ToArray();
        
        var (a, b) = LeastSquareRegressionLineSolver.LeastRegressionLine(xValues, yValues);
        Console.WriteLine(text
            .Replace("a", a.ToString())
            .Replace("b", b.ToString()));
    }
}