namespace ToDoApi.Models
{
    public class ToDoContext : DbContext {
        public ToDoContext(DbContextOptions<ToDoContext> DBOptions) : base(DBOptions) {
            public DbSet<ToDoItem> ToDoItems { get; set; }

        }
    
    }
}