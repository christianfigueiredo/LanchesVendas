using CadastroDeContatos.Data;
using CadastroDeContatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly ContatoContext _contatoContext;
        public ContatoRepositorio(ContatoContext contatoContext)
        {
            _contatoContext = contatoContext;
        }
        public Contato Adicionar(Contato contato)
        {
            //gravar no banco de dados
            _contatoContext.contatos.Add(contato);
            _contatoContext.SaveChanges();
            return contato;
        }
        public Contato ListaPorId(int id)
        {
            return _contatoContext.contatos.FirstOrDefault(x=>x.ContatoId==id);
        }
        public List<Contato> BuscarTodos()
        {
            return _contatoContext.contatos.ToList();
        }

        public Contato Atualizar(Contato contato)
        {
            Contato contatoDB = ListaPorId(contato.ContatoId);

            if (contatoDB == null) throw new System.Exception("Erro na atualização do contato!");
            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _contatoContext.Update(contatoDB);
            _contatoContext.SaveChanges();

            return contatoDB;

        }
        
        public bool Apagar(int id)
        {
            Contato contatoDB = ListaPorId(id);

            if (contatoDB == null) throw new System.Exception("Erro na deleção do contato!");
            _contatoContext.contatos.Remove(contatoDB);
            _contatoContext.SaveChanges();
            return true;


        }
    }
}
