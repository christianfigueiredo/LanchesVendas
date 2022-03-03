

using LanchesOnLine.Models;
using LanchesOnLine.Repositories.Interfaces;
using LanchesOnLine.Context;

namespace LanchesOnLine.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;            
    }
}
