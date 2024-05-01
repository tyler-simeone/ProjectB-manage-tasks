public class TaskList : ResponseBase
{
    public TaskList()
    {
        Tasks = new List<Task>();
    }

    public List<Task> Tasks { get; set; }

    public int PageNumber { get; set; }

    public int PageSize { get; set; }
}