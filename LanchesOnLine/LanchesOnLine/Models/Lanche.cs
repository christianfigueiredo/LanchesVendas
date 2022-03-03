using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesOnLine.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80,MinimumLength = 10, ErrorMessage ="O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage ="A Descrição deve ter no minino {1} caracter")]
        [MaxLength(200, ErrorMessage = "A Descrição não dever exceder {1} caracter")]
        public string DescricaoCurta { get; set; }
        
        [NotMapped]
        public DateTime DataDeCriacao { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A Descrição detalhada deve ter no minino {1} caracter")]
        [MaxLength(200, ErrorMessage = "A Descrição detalhada não dever exceder {1} caracter")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name ="Estoque")]
        public bool EmEstoque { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage ="O {0} deve ter no maximo {1} caracteres")]
        public string  ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImagemThumbnaiUrl { get; set; }

        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name ="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage =" O preço deve estar entre 1 e 999.99")] 
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}