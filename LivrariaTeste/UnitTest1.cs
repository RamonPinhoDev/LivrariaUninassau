// Adicione esta diretiva using no início do arquivo de teste (UnitTest1.cs)
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using LivrariaUninassau;
using Microsoft.VisualStudio.TestPlatform.TestHost; // Certifique-se de que o namespace correto está sendo importado

namespace LivrariaTeste
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public IntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task TestEndpoint()
        {
            // Arrange
            var client = _factory.CreateClient(); // Corrija aqui para criar o cliente corretamente

            // Act
            var response = await client.GetAsync("\"{id}\"");

            // Assert
            response.EnsureSuccessStatusCode();
            // Adicione mais assertivas com base nos seus requisitos
        }
    }
}

// Certifique-se de que o namespace do projeto principal está correto no arquivo de teste (UnitTest1.cs)
namespace LivrariaUninassau
{
    public class WebApplicationFactory<T>
    {
        internal HttpClient CreateClient()
        {
            return new HttpClient();
        }
    }
}

