namespace Assignment3cs.Tasks;

public class Task5 : TaskBase
{
    public override void Solve()
    {
        var text = "Function: y = ax + b/x";
        Console.WriteLine(text);
        
        var xValues = new[] { 1.0, 2, 3, 4, 5, 6, 7, 8};
        var yValues = new[] { 5.4, 6.3, 8.2, 10.3, 12.6, 14.9, 17.3, 19.5};
        
        // Transform function to Y = b + aX, where Y = yx and X = x^2
        xValues = xValues
            .Select(x => x * x)
            .ToArray();
        
        yValues = Enumerable
            .Range(0, yValues.Length)
            .Select(i => yValues[i] * xValues[i])
            .ToArray();
        
        var (a, b) = LeastSquareRegressionLineSolver.LeastRegressionLine(xValues, yValues);
        
        // Swap a and b regarding by the transformed function
        (a, b) = (b, a);
        
        Console.WriteLine(text
            .Replace("a", a.ToString())
            .Replace("b", b.ToString()));
    }
}