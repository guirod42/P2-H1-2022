using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static Calculadora.Pessoa;

namespace Calculadora.Model
{
    public class PessoaViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 2, ErrorMessage = "Valor de {0} deve estar entre {1} - Feminino e {2} - Masculino.")]
        public EnumSexo Sexo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(18, 40, ErrorMessage = "A {0} deve estar entre {1} e {2} anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 300, ErrorMessage = "O {0} deve estar entre {1} e {2} quilos")]
        public int Peso { get; set; }
    }
}
