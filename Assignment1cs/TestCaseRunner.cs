using System.Reflection;
using Assignment1cs.Abstract;

namespace Assignment1cs;

public static class TestCaseRunner
{
    public static void Run<T>(T algorithm) where T: Algorithm
    {
       var getMethod = typeof(T).GetProperty("TestCases")?.GetGetMethod() 
                       ?? throw new ArgumentException("No TestCases");
       var testCases = ((double, double, Func<double, double>)[]) 
           (getMethod.Invoke(algorithm, null) ?? throw new ArgumentException("Cannot take test cases"));

       int passedCount = 0;
       foreach (var (testCase, i) in testCases.Select((item, index) => (item, index)))
       {
           Console.WriteLine($"[TestCase: {i} -> ({testCase.Item1} {testCase.Item2})] ...");
           try
           {
               Console.WriteLine($"... Result: {algorithm.Run(testCase)}");
               passedCount++;
           }
           catch (ArgumentException e)
           {
               Console.WriteLine($"... Error: {e.Message}");
           }
       }

       Console.WriteLine($"\nPassed: {passedCount}/{testCases.Length}");
       
    }
}