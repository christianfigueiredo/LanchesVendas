using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesVendas.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public bool EmEstoque { get; set; }
        public bool IsLanchePreferido { get; set; }
        public string  ImagemUrl { get; set; }
        public string ImagemThumbnaiUrl { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}