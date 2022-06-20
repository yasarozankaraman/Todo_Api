using Microsoft.EntityFrameworkCore;

namespace Todo_Api.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }


}
