using Microsoft.EntityFrameworkCore;
using Domain.Entity;
namespace Infrastructure.Context

{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet <Category> Category {get; set;}
        public DbSet <Product> Product {get; set;}
    }
}