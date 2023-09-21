using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParOuImparChecker.Controllers;
using Xunit;

namespace ParOuImparChecker.Tests.Controllers
{
    [TestClass()]
    public class VerificarParidadeControllerTests
    {
        [TestMethod()]
        public void VerificarParidadeTest()
        {
            Assert.Fail();
        }

        [Fact]
        public void VerificarParidade_ResultadoPar_ValidacaoCorreta()
        {
            // Arrange
            var controller = new VerificarParidadeController();

            // Act
            var resultado = controller.VerificarParidade(2, "par");

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(resultado);
            var model = Assert.IsAssignableFrom<VerificarParidadeResponse>(okResult.Value);
            Assert.True(model.Vitoria);
            Assert.Equal("Você venceu!", model.Mensagem);
        }
    }
}