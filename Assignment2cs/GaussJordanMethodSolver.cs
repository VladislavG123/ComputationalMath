namespace Assignment2cs;

public static class GaussJordanMethodSolver
{
    public static void Solve(float[,] matrix) => matrix
        .InputCheck()
        .Pivoting()
        .Elimination()
        .BackInsertion();

    private static void BackInsertion(this float[,] matrix)
    {
        Console.WriteLine("BackInsertion:");
        for (var row = matrix.GetRowCount() - 1; row >= 0; row--)
        {
            var item = matrix[row, row];
            if (item == 0) return;

            for (var i = 0; i < matrix.GetRowCount() + 1; i++)
                matrix[row, i] /= item;

            for (var destRow = 0; destRow < row; destRow++)
            {
                matrix[destRow, matrix.GetRowCount()] -= matrix[destRow, row] * matrix[row, matrix.GetRowCount()];
                matrix[destRow, row] = 0;
            }

            MatrixHelper.PrintMatrix(matrix);
        }
    }
}