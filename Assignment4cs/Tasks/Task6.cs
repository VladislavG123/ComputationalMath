namespace Assignment4cs.Tasks;

public class Task6 : TaskBase
{
    public new static TestCase TestCase()
    {
        var values = new[] { 2.0, 3, 4, 6 };
        return new(values, 5)
        {
            DifferenceTable = GenerateDifferenceTable(45.0, 49.2, 54.1, 67.4)
        };
    }
}