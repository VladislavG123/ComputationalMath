namespace Assignment4cs.Tasks;

public class Task3 : TaskBase
{
    public new static TestCase TestCase()
    {
        var values = new[] { 0.0, 1, 2, 3, 4, 5 };
        return new(values, 6)
        {
            DifferenceTable = GenerateDifferenceTableFromFunction(values, 
                x => (x * x * x) + (x * x) - 2 * x + 1)
        };
    }
}