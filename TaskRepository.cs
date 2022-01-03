namespace ExampleServer.Data;

class TaskRepository
{
    private readonly List<TaskModel> _taskList = new List<TaskModel>();

    // Create (Add)
    public void AddTask(TaskModel task)
    {
        _taskList.Add(task);
    }

    // Read (Read)
    public List<TaskModel> GetTasks()
    {
        return _taskList;
    }

    // Update (Update)

    // Delete (Delete)
    public void DeleteTaskById(int id)
    {
        foreach (TaskModel task in _taskList)
        {
            if (task.Id == id)
            {
                _taskList.Remove(task);
                return;
            }
        }
    }
}