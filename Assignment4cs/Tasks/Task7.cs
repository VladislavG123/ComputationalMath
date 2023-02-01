namespace Assignment4cs.Tasks;

public class Task7 : TaskBase
{
    public new static TestCase TestCase()
    {
        var values = new[] { -1, 0.0, 1, 2, 3, 4, 5 };
        return new(values, 6)
        {
            DifferenceTable = GenerateDifferenceTableFromFunction(values, x =>
            {
                var result = 1.0;
                for (int i = 1; i <= 15; i+=2)
                {
                    result *= 2 * x + 1;
                }

                return result;
            })
        };
    }
}