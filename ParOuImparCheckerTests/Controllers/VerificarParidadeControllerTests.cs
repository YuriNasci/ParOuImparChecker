using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace ParOuImparChecker.Controllers.Tests
{
    public class VerificarParidadeControllerTests
    {
        [Fact]
        public void VerificarParidade_ParametrosValidos_DeveRetornarOkObject()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(2, "par");

            // Assert
            Assert.IsInstanceOfType(resultado.GetType(), typeof(OkObjectResult));
        }

        [Fact]
        public void VerificarParidade_ParametrosInvalidos_DeveRetornarBadRequest()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(6, "invalido");

            // Assert
            Assert.IsInstanceOfType(resultado.GetType(), typeof(BadRequestResult));
        }
    }
}