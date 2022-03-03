using LanchesOnLine.Models;

namespace LanchesOnLine.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
