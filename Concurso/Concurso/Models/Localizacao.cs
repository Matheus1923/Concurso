using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Concurso.Models
{
    [Table("Localizacao")]
    public class Localizacao
    {
        [Key]
        [Column("idlocalizacao")]
        [Required (ErrorMessage = "O campo é Obrigatório")]

        public Int32 IdLocalizacao { get; set; }

        [Required]
        [StringLength(30 , MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 30")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(30 , MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 30")]
        [Column("endereco")]

        public string Endereco { get; set; }
    }
}
