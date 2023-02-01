namespace Assignment4cs.Tasks;

public class TaskBase
{
    protected static double[,] GenerateDifferenceTable(params double[] values)
    {
        var n = values.Length;
        var table = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            table[i, 0] = values[i];
        }

        return table;
    }
    
    protected static double[,] GenerateDifferenceTableFromFunction(double[] values, Func<double, double> function)
        => GenerateDifferenceTable(values.Select(function).ToArray());
    

    public record TestCase(double[] Values, double ValueToInterpolateAt)
    {
        public double[,] DifferenceTable { get; init; }
    }    
}