using ExampleServer.Data;
using ExampleServer.Server;

TaskModel firstTask = new TaskModel("This is my first task.");
TaskModel secondTask = new("This is my second task.");

Console.WriteLine($"First task id: {firstTask.Id}");
Console.WriteLine($"Second task id: {secondTask.Id}");

TaskRepository repo = new();
repo.AddTask(firstTask);
repo.AddTask(secondTask);

//repo.DeleteTaskById(1);

List<TaskModel> tasks = repo.GetTasks();
foreach (TaskModel task in tasks)
{
    Console.WriteLine(task.Message);
}

WebServer webServer = new WebServer("http://localhost:8000/", repo);
WebServer.ReferenceEquals();