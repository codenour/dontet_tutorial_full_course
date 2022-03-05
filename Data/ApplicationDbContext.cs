using dotnetCode.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCode.Data;

public class ApplicationDbContext : DbContext
{   
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {

    }

    public DbSet<user> users {get;set;}
}
