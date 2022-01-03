namespace ExampleServer.Data;

class TaskModel
{
    private static int TotalTasks = 0;

    public TaskModel(string message)
    {
        Id = ++TotalTasks; // Id = 1, TotalTasks = 1
        // Id = TotalTasks++; // Id = 0, TotalTasks = 1
        Message = message;
    }

    public int Id { get; }
    public string Message { get; set; }
}