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
        [StringLength(80,MinimumLength = 10, ErrorMessage ="O {0} deve ter no minimo {1} e no m�ximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="A descri��o do lanche deve ser informada")]
        [Display(Name = "Descri��o do Lanche")]
        [MinLength(20, ErrorMessage ="A Descri��o deve ter no minino {1} caracter")]
        [MaxLength(200, ErrorMessage = "A Descri��o n�o dever exceder {1} caracter")]
        public string DescricaoCurta { get; set; }
        
        [NotMapped]
        public DateTime DataDeCriacao { get; set; }

        [Required(ErrorMessage = "A descri��o do lanche deve ser informada")]
        [Display(Name = "Descri��o detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A Descri��o detalhada deve ter no minino {1} caracter")]
        [MaxLength(200, ErrorMessage = "A Descri��o detalhada n�o dever exceder {1} caracter")]
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

        [Required(ErrorMessage ="Informe o pre�o do lanche")]
        [Display(Name ="Pre�o")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage =" O pre�o deve estar entre 1 e 999.99")] 
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}