using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesVendas.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {            
        }
        public DbSet<Categoria> Categorias {get; set; }
        public DbSet<Lanche> Lanches {get; set; }
    }
}