using Calculadora.Model;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static Calculadora.Pessoa;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GastoCaloricoController : Controller
    {
        [Route("GastoCaloricoBasal")]
        [HttpGet]
        public IActionResult GastoCaloricoBasal([FromQuery] PessoaViewModel pessoa)
        {
            double calorias = 0;
            if (pessoa.Idade >= 18 || pessoa.Idade <= 30)
            {
                if (pessoa.Sexo == EnumSexo.Feminino)
                {
                    calorias = ((0.062 * pessoa.Peso + 2.036) * 239);
                }
                else
                {
                    calorias = ((0.063 * pessoa.Peso + 2.896) * 239);
                }               
            }
            else if (pessoa.Idade >= 31 || pessoa.Idade <= 40)
            {
                if (pessoa.Sexo == EnumSexo.Feminino)
                {
                    calorias = ((0.034 * pessoa.Peso + 3.538) * 239);
                }
                else
                {
                    calorias = ((0.048 * pessoa.Peso + 3.653) * 239);
                }
            }
            if (calorias > 0) return Ok(new { success = true, gastocalorico = calorias });

            else return BadRequest(new { success = false, message = "Não foi possível calcular" });
        }

        [Route("GastoCaloricoAtividade")]
        [HttpGet]
        public IActionResult GastoCaloricoAtividade(string atividade, int tempo)
        {
            if (atividade ==  "strings")

            if (atividade == "Caminhada(piso plano)")
                return Ok(new { success = true, gastocalorico = 6.1 * tempo });
            if (atividade == "Trabalho doméstico")
                return Ok(new { success = true, gastocalorico = 4.6 * tempo });
            if (atividade == "Corrida(5 min / Km)")
                return Ok(new { success = true, gastocalorico = 16 * tempo });
            if (atividade == "Bicicleta(9 km / h)")
                return Ok(new { success = true, gastocalorico = 4.9 * tempo });
            if (atividade == "Bicicleta(15 Km / h)")
                return Ok(new { success = true, gastocalorico = 7.7 * tempo });
            if (atividade == "Alongamento")
                return Ok(new { success = true, gastocalorico = 5.4 * tempo });
            return BadRequest(new { success = false, message = "Atividade não existe,calculo não pode ser realizado" });
        }
    }
}
