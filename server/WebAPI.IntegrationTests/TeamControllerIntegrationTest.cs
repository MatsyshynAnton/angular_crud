using Common.DTO;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebAPI.IntegrationTests
{
    public class TeamControllerIntegrationTest: IClassFixture<CustomWebApplicationFactory>
    {
        readonly HttpClient _client;
        readonly string endpoint;

        public TeamControllerIntegrationTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
            endpoint = "api/team/";
        }

        [Fact]
        public async Task CreateTeam_WhenParametersValid_Than201Created()
        {
            var team = new TeamDTO
            {
                Name = "New team!"
            };

            var response = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(team), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task CreateTeam_WhenNameDoesNotSpecified_Than400BadRequest()
        {
            var team = new TeamDTO
            {
                Name = null
            };

            var response = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(team), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
