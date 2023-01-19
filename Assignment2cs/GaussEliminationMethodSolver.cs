namespace Assignment2cs;

public static class GaussEliminationMethodSolver
{
    public static void Solve(float[,] matrix) => matrix
        .InputCheck()
        .Pivoting()
        .Elimination()
        .FindRoots()
        .PrintRoots();

    private static float[] FindRoots(this float[,] matrix)
    {
        var rowCount = matrix.GetRowCount();
        var roots = new float[rowCount];

        for (int i = rowCount - 1; i >= 0; i--)
        {
            var answer = matrix[i, rowCount];
            for (int j = rowCount - 1; j >= 0; j--)
            {
                if (i == j)
                {
                    roots[i] = answer / matrix[i, j];
                }
                else
                {
                    answer -= matrix[i, j] * roots[j];
                }
            }
        }

        return roots;
    }

    private static void PrintRoots(this float[] roots)
        => Console.WriteLine("Roots: " + string.Join(" ", roots));
}