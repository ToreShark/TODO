using Microsoft.EntityFrameworkCore;
using To_Do_list.Models;

namespace To_Do_list.Data;

public class TODOContext : DbContext
{
    public TODOContext(DbContextOptions<TODOContext> options) : base(options)
    {
    }
    public DbSet<TaskEntity> Tasks { get; set; }
}