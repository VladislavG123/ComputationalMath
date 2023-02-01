namespace Assignment4cs.Tasks;

public class Task1 : TaskBase
{
    public new static TestCase TestCase() =>
        new(new[] { 10.0, 20, 30, 40 }, 40)
        {
            DifferenceTable = GenerateDifferenceTable(1.1, 2.0, 4.4, 7.9)
        };
}