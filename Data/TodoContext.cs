using Microsoft.EntityFrameworkCore;

namespace Todo.Data;

public class TodoContext : DbContext
{
    public DbSet<Todo>? todo { get; set; }
    
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
        
    }
}