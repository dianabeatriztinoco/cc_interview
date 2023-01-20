// main class that coordinates entity framework functionality for a data model used in each crud method 
// you must register the database context

using Microsoft.EntityFrameworkCore; // equivalent to import in JavaScript // directive specifying use of a resource 

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}