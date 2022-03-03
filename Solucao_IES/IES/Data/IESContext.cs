using IES.Models;
using Microsoft.EntityFrameworkCore;

namespace IES.Data
{ 
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options): base(options)
        {            
        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Instituicao>().ToTable("Instituicao");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IESDB;" +
                "Trusted_Connection=true;MultipleActiveResultSets=true");                
        }
    }
 }
