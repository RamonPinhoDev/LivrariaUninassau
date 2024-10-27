using System.Net.Http;
using System.Threading.Tasks;
using LivrariaUninassau.Tests;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace LivrariaUninassau.Tests
{
    public class LivrariaControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        private readonly WebApplicationFactory<Program> _factory;

        public LivrariaControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient(); // Inicializa o cliente HTTP
        }

        [Fact]
        public async Task Get_Emprestimos_DeveRetornarListaDeEmprestimos()
        {
            // Use o _client para fazer chamadas à sua aplicação
            HttpResponseMessage response = await _client.GetAsync("/api/Livraria");

            // Adicione as verificações e assertivas necessárias para o seu teste
            // Exemplo: Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

