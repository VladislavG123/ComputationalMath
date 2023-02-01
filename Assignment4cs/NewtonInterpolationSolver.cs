namespace Assignment4cs;

public static class NewtonInterpolationSolver
{
    public static double SolveForwardInterpolation(double[] values, double[,] differenceTable,
        double valueToInterpolateAt)
        => differenceTable
            .CalculateForwardDifference()
            .DisplayForwardDifferenceTable(values)
            .GetSum(values, valueToInterpolateAt);
    
    private static double[,] CalculateForwardDifference(this double[,] differenceTable)
    {
        var n = differenceTable.GetLength(0);
        for (var i = 1; i < n; i++)
        for (var j = 0; j < n - i; j++)
            differenceTable[j, i] = differenceTable[j + 1, i - 1] - differenceTable[j, i - 1];

        return differenceTable;
    }

    private static double[,] DisplayForwardDifferenceTable(this double[,] differenceTable, double[] values)
    {
        int n = values.Length;
        for (int i = 0; i < n; i++)
        {
            Console.Write(values[i] + "\t");
            for (int j = 0; j < n - i; j++)
                Console.Write(differenceTable[i, j] + "\t");
            Console.WriteLine();
        }

        return differenceTable;
    }

    private static double GetSum(this double[,] differenceTable, double[] values, double valueToInterpolateAt)
    {
        var sum = differenceTable[0, 0];
        var u = (valueToInterpolateAt - values[0]) / (values[1] - values[0]);
        for (var i = 1; i < values.Length; i++)
            sum += UCalculation(u, i) * differenceTable[0, i] / CalculateFactorial(i);

        return sum;
    }
    
    /// <summary>
    /// Calculating u mentioned in the formula
    /// </summary>
    private static double UCalculation(double u, int n)
    {
        var temp = u;
        for (var i = 1; i < n; i++) temp *= u - i;
        return temp;
    }

    /// <summary>
    /// Calculating factorial of given number n
    /// </summary>
    private static int CalculateFactorial(int n)
    {
        var f = 1;
        for (var i = 2; i <= n; i++) f *= i;
        return f;
    }
}