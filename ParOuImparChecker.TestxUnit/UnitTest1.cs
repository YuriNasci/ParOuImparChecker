using Microsoft.AspNetCore.Mvc;
using ParOuImparChecker.Controllers;
using ParOuImparChecker.Models.Dto;

namespace ParOuImparChecker.TestxUnit
{
    public class UnitTest1
    {
        [Fact]
        public void VerificarParidade_ParametrosValidos_DeveRetornarOkObject()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(2, "par");
            var verificarParidadeResultDto = resultado as ActionResult<VerificarParidadeResultDto>;

            //Assert.IsInstanceOfType(verificarParidadeResultDto.Result, typeof(OkObjectResult));
            Assert.IsType<OkObjectResult>(verificarParidadeResultDto.Result);
        }

        [Fact]
        public void VerificarParidade_ParametrosInvalidos_DeveRetornarBadRequest()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(8, "par");
            var verificarParidadeResultDto = resultado as ActionResult<VerificarParidadeResultDto>;

            Assert.IsType<BadRequestObjectResult>(verificarParidadeResultDto.Result);
        }
    }
}