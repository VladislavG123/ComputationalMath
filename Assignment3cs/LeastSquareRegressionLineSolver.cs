namespace Assignment3cs;

public static class LeastSquareRegressionLineSolver
{
    private static double CalculateB(double[] xValues, double[] yValues)
    {
        var n = xValues.Length;
        
        var sumOfX = xValues.Sum();
        var sumOfY = yValues.Sum();

        var sumOfXY = Enumerable.Range(0, n)
            .Select(i => xValues[i] * yValues[i])
            .Sum();
        
        var sumOfXX = xValues
            .Select(x => x * x)
            .Sum();

        return (double)(n * sumOfXY - sumOfX * sumOfY) / (n * sumOfXX - sumOfX * sumOfX);
    }

    public static (double A, double B) LeastRegressionLine(double[] xValues, double[] yValues)
    {
        var b = CalculateB(xValues, yValues);

        var n = xValues.Length;
        var meanX = xValues.Sum() / n;
        var meanY = yValues.Sum() / n;

        var a = meanY - b * meanX;

        return (a, b);
    }
}