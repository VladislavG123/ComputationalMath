namespace Assignment2cs;

public static class MatrixHelper
{
    public static void PrintMatrix(float[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i,j].ToString().PadLeft(3, ' '));
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("----------------\n");
    }
}