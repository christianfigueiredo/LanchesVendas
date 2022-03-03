using CadastroDeContatos.Models;
using System.Collections.Generic;

namespace CadastroDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        Contato ListaPorId(int id);
        List<Contato> BuscarTodos();
        Contato Adicionar(Contato contato);
        Contato Atualizar(Contato contato);
        bool Apagar(int id);
    }
}
