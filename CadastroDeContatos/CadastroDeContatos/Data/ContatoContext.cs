using CadastroDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeContatos.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {
        }
        public DbSet<Contato> contatos { get; set; }
    }
}
