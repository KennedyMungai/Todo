namespace Todo.Data;

public class Todo
{
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public string? Item { get; set; }
    public DateTime DeadLine { get; set; }
    public bool IsDone { get; set; }
}