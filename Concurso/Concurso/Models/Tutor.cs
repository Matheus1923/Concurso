using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Concurso.Models
{
    [Table("Tutor")]
    public class Tutor
    {
        [Key]
        [Column("idtutor")]
        [Required(ErrorMessage = "O campo é Obrigatório")]
        public Int32 IdTutor { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 30")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 30")]
        [Column("email")]

        public string Email { get; set; }

        [Column("identificacao")]
        [Required(ErrorMessage = "O campo é Obrigatório")]

        public decimal Identificacao { get; set; }

        [Column("idlocalizacao")]
        [Required(ErrorMessage = "O campo deve ser Obrigatório")]

        public int IdLocalizacao { get; set; }
    }
}
