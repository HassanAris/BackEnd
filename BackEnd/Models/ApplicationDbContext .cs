using BackEnd.Models;
using EventosAPI.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurações adicionais podem ser feitas aqui, se necessário
    }
    public DbSet<Livro> Livro { get; set; }
}
