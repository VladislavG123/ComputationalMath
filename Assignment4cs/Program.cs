using Assignment4cs;
using Assignment4cs.Tasks;


var testCase = Task1.TestCase();

Console.WriteLine("\nValue at " + testCase.ValueToInterpolateAt + " is " +
                  Math.Round(
                      NewtonInterpolationSolver.SolveForwardInterpolation(
                          testCase.Values,
                          testCase.DifferenceTable,
                          testCase.ValueToInterpolateAt),
                      6));