namespace Application_Task.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime TaskDate { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CreatedTask { get; set; }
        public DateTime UpdateTask { get; set; }

        public List<SubTaskModel> SubTask { get; set; } = new List<SubTaskModel>();
    }
}
