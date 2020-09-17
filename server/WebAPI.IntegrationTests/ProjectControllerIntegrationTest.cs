using Common.DTO;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebAPI.IntegrationTests
{
    public class ProjectControllerIntegrationTest:IClassFixture<CustomWebApplicationFactory>
    {
        readonly HttpClient _client;
        readonly string endpoint;
        public ProjectControllerIntegrationTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
            endpoint = "api/project";
        }
        [Fact]
        public async Task CreateProject_WhenParametersValid_Than201Created()
        {
            var project = new ProjectDTO
            {
                Name = "test project name",
                Description = "test project description",
                AuthorId = 1,
                TeamId = 1,
            };

            var response = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(project), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Theory]
        [InlineData("{\"id\":0,\"name\":\"Test project name\",\"description\":\"Test project description\"," +
                    "\"createdAt\":\"2020 - 06 - 22T15: 51:35.3601713\",\"deadline\":\"2020 - 07 - 26T15: 51:35.3601716\"," +
                    "\"authorId\":0,\"teamId\":6}")]
        [InlineData("{\"id\":0,\"name\":\"Test project name\",\"description\":\"Test project description\"," +
                    "\"createdAt\":\"2020 - 06 - 22T15: 51:35.3601713\",\"deadline\":\"2020 - 07 - 26T15: 51:35.3601716\"," +
                    "\"authorId\":1,\"teamId\":0}")]
        [InlineData("{\"id\":0,\"name\":null,\"description\":\"Test project description\"," +
                    "\"createdAt\":\"2020 - 06 - 22T15: 51:35.3601713\",\"deadline\":\"2020 - 07 - 26T15: 51:35.3601716\"," +
                    "\"authorId\":1,\"teamId\":1}")]
        [InlineData("{\"id\":0,\"name\":\"Test project name\",\"description\": null," +
                    "\"createdAt\":\"2020 - 06 - 22T15: 51:35.3601713\",\"deadline\":\"2020 - 07 - 26T15: 51:35.3601716\"," +
                    "\"authorId\":1,\"teamId\":1}")]
        [InlineData("{\"id\":0,\"name\":\"Test project name\",\"description\": \".\"," +
                    "\"createdAt\":\"2020 - 06 - 22T15: 51:35.3601713\",\"deadline\":\"2020 - 07 - 26T15: 51:35.3601716\"," +
                    "\"authorId\":1,\"teamId\":1}")]
        public async Task CreateProject_WhenParametersInvalid_Than400BadRequest(string jsonInString)
        {
            var response = await _client.PostAsync(endpoint, new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
