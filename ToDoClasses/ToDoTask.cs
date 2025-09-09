namespace ToDoClasses
{
    public class ToDoTask
    {
        public string? TaskName { get; set; }
        public bool IsTaskCompleted { get; set; }
        public ToDoTask(string taskName)
        {
            TaskName = taskName;
            IsTaskCompleted = false;

        }
    }
}