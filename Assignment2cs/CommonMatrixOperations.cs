namespace Assignment2cs;

public static class CommonMatrixOperations
{
    public static int GetRowCount(this float[,] matrix) => matrix.GetUpperBound(0) + 1;

    public static float[,] InputCheck(this float[,] matrix)
    {
        if (matrix.Length != matrix.GetRowCount() * (matrix.GetRowCount() + 1))
            throw new ArgumentException("The algorithm must be provided with a (n x n+1) matrix.");
        if (matrix.GetRowCount() < 1)
            throw new ArgumentException("The matrix must at least have one row.");

        Console.WriteLine("Passed InputCheck:");
        MatrixHelper.PrintMatrix(matrix);

        return matrix;
    }

    public static float[,] Pivoting(this float[,] matrix)
    {
        for (int col = 0; col + 1 < matrix.GetRowCount(); col++)
        {
            if (matrix[col, col] != 0) continue;

            // check for zero coefficients
            // find non-zero coefficient
            int swapRow = col + 1;
            for (; swapRow < matrix.GetRowCount(); swapRow++)
                if (matrix[swapRow, col] != 0)
                    break;

            if (matrix[swapRow, col] != 0) // found a non-zero coefficient?
            {
                // yes, then swap it with the above
                for (int i = 0; i < matrix.GetRowCount() + 1; i++)
                {
                    (matrix[col, i], matrix[swapRow, i]) = (matrix[swapRow, i], matrix[col, i]);
                }
            }
            else throw new InvalidOperationException("The matrix has no unique solution");
        }

        Console.WriteLine("After Pivoting:");
        MatrixHelper.PrintMatrix(matrix);
        return matrix;
    }

    public static float[,] Elimination(this float[,] matrix)
    {
        Console.WriteLine("Elimination:");
        for (var sourceRow = 0; sourceRow + 1 < matrix.GetRowCount(); sourceRow++)
        {
            for (var destRow = sourceRow + 1; destRow < matrix.GetRowCount(); destRow++)
            {
                var destItem = matrix[sourceRow, sourceRow];
                var sourceItem = matrix[destRow, sourceRow];
                for (var i = 0; i < matrix.GetRowCount() + 1; i++)
                    matrix[destRow, i] = matrix[destRow, i] * destItem - matrix[sourceRow, i] * sourceItem;

                MatrixHelper.PrintMatrix(matrix);
            }
        }

        return matrix;
    }
}