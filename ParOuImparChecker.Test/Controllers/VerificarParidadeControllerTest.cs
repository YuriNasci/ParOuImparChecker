using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParOuImparChecker.Controllers;
using ParOuImparChecker.Models.Dto;

namespace ParOuImparChecker.Test.Controllers
{
    [TestClass()]
    public class VerificarParidadeControllerTest
    {
        [TestMethod()]
        public void VerificarParidade_ParametrosValidos_DeveRetornarOkObject()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(2, "par");
            var verificarParidadeResultDto = resultado as ActionResult<VerificarParidadeResultDto>;

            Assert.IsInstanceOfType(verificarParidadeResultDto.Result, typeof(OkObjectResult));
        }

        [TestMethod()]
        public void VerificarParidade_ParametrosInvalidos_DeveRetornarBadRequest()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(8, "par");
            var verificarParidadeResultDto = resultado as ActionResult<VerificarParidadeResultDto>;

            Assert.IsInstanceOfType(verificarParidadeResultDto.Result, typeof(BadRequestObjectResult));
        }
    }
}