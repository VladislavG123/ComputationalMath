// See https://aka.ms/new-console-template for more information

using Assignment2cs;

#region TestCases

var taskATestCases = new[]
{
    new float[,]
    {
        { 2, 6, 7, 52 },
        { 2, 1, -1, 0 },
        { 1, 1, 1, 9 }
    },
    new float[,]
    {
        { 2, 1, 5, 1, 5 },
        { 1, 1, -3, 4, -1 },
        { 3, 6, -2, 1, 8 },
        { 2, 2, 2, 3, 2 }
    },
};

var taskBTestCases = new[]
{
    new float[,]
    {
        { 1, 1, 1, 9 },
        { 2, -3, 4, 13 },
        { 3, 4, 5, 40 }
    },
    new float[,]
    {
        { 5, 1, 1, 1, 4 },
        { 1, 7, 1, 1, 12 },
        { 1, 1, 6, 1, -5 },
        { 1, 1, 1, 4, -6 }
    },
};

#endregion



//GaussJordanMethodSolver.Solve(taskATestCases[1]);
GaussEliminationMethodSolver.Solve(taskBTestCases[0]);