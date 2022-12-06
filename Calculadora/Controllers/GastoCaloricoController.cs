using Calculadora;
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
        public IActionResult GastoCaloricoAtividade([FromQuery] AtividadeViewModel atividade)
        {
            if(atividade.Descricao == "Caminhada(piso plano)")
                return Ok(new { success = true, gastocalorico = 6.1 * atividade.TempoMin });
            if (atividade.Descricao == "Trabalho doméstico")
                return Ok(new { success = true, gastocalorico = 4.6 * atividade.TempoMin });
            if (atividade.Descricao == "Corrida(5 min / Km)")
                return Ok(new { success = true, gastocalorico = 16 * atividade.TempoMin });
            if (atividade.Descricao == "Bicicleta(9 km / h)")
                return Ok(new { success = true, gastocalorico = 4.9 * atividade.TempoMin });
            if (atividade.Descricao == "Bicicleta(15 Km / h)")
                return Ok(new { success = true, gastocalorico = 7.7 * atividade.TempoMin });
            if (atividade.Descricao == "Alongamento")
                return Ok(new { success = true, gastocalorico = 5.4 * atividade.TempoMin });
            return BadRequest(new { success = false, message = "Atividade não existe, calculo não pode ser realizado" });
        }
    }
}
