using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_dotnet.models
{
    public class Produto
    {  
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "O nome do produto tem que ter entre a 6 letras a 100.")]
        public string Nome { get; set; }

        [StringLength(450, ErrorMessage = "Ultrapassou o limite de letras")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        public decimal Preco { get; set; }

        [DefaultValue(1)]
        public int Quantidade { get; set; }

   

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
   

    }
}