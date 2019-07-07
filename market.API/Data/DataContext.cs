using market.API.Models;
using Microsoft.EntityFrameworkCore;

namespace market.API.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<Value> Values {get;set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photo { get; set; }
    }
}