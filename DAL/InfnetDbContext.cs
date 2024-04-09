using InfnetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace InfnetMVC.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options) : base(options)
        {
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
                .Property(f => f.Nome)
                .HasMaxLength(50);
        }
    }
}