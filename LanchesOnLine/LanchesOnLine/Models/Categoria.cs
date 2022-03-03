using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LanchesOnLine.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage ="O tamanho Máximo é {1} Caracteres")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        [StringLength(200, ErrorMessage = "O tamanho Máximo é {1} Caracteres")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }

    }
}