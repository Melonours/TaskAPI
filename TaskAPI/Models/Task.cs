namespace TaskAPI.Models
{
    public class Task
    {
        public Task(int taskId, string title, string description)
        {
            TaskId = taskId;
            Title = title;
            Description = description;
        }

        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
