namespace Assignment4cs.Tasks;

public class Task2 : TaskBase
{
    public new static TestCase TestCase() =>
        new(new[] { 0.0, 1, 2, 3, 4 }, 2)
        {
            DifferenceTable = GenerateDifferenceTable(1.0, 1.5, 2.2, 3.1, 4.6)
        };
}