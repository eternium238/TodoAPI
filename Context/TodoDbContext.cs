using Microsoft.EntityFrameworkCore;
using TodoAPI.Model;

namespace TodoAPI.Context
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }
        
        public DbSet<Todo> Todo { get; set; }
    }
}
