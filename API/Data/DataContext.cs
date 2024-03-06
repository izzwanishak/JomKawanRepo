using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

//entity name: AppUser
//table name: Users
    public DbSet<AppUser> Users { get; set; }
}
