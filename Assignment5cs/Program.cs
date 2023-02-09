using Assignment5cs.Tasks;

var tasks = new List<Action>
{
    Task1.Run,
    Task2.Run,
    Task3.Run,
    Task4.Run,
};

tasks.ForEach(task =>
    {
        Console.WriteLine();
        task.Invoke();
    });