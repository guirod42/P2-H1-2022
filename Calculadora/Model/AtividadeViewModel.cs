using static Calculadora.Pessoa;
using System.ComponentModel.DataAnnotations;

namespace Calculadora.Model
{
    public class AtividadeViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 3600, ErrorMessage = "O {0} deve estar entre {1} e {2} Minutos")]
        public int TempoMin { get; set; }
    }
}
