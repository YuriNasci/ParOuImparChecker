using Microsoft.AspNetCore.Mvc;

namespace ParOuImparChecker.Controllers
{
    [Route("api/verificar-paridade")]
    [ApiController]
    public class VerificarParidadeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<bool> VerificarParidade(int numeroEntrada, string parOuImpar)
        {
            if (numeroEntrada < 0 || numeroEntrada > 5 || (parOuImpar != "par" && parOuImpar != "impar"))
            {
                return BadRequest("Os parâmetros fornecidos não são válidos.");
            }

            Random random = new Random();
            int numeroAleatorio = random.Next(0, 6);

            int soma = numeroEntrada + numeroAleatorio;
            bool resultado = (soma % 2 == 0 && parOuImpar == "par") || (soma % 2 != 0 && parOuImpar == "impar");
            string mensagem = resultado ? "Você venceu!" : "Você perdeu!";

            return Ok(new
            {
                Mensagem = mensagem,
                Vitoria = resultado,
                NumeroEntrada = numeroEntrada,
                Aposta = parOuImpar,
                NumeroAleatorioGerado = numeroAleatorio,
                Soma = soma,
            });
        }
    }

}
