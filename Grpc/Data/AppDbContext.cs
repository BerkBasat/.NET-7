using Grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace Grpc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<ToDoItem> toDoItems => Set<ToDoItem>();
}