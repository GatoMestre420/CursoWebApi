using API.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication;


public class AppDbContext : DbContext{

   public DbSet<Categoria>? Categorias { get; set; }    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=app.db");
    }


}