using static Calculadora.Pessoa;
using System.ComponentModel.DataAnnotations;

namespace Calculadora.Model
{
    public class AtividadeViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 2, ErrorMessage = "Valor de {0} deve estar entre {1} - Feminino e {2} - Masculino.")]
        public EnumSexo Sexo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 3600, ErrorMessage = "O {0} deve estar entre {1} e {2} Minutos")]
        public int Minutos { get; set; }
    }
}
