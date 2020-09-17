using Common.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebAPI.IntegrationTests
{
    public class TaskControllerIntegrationTest: IClassFixture<CustomWebApplicationFactory>
    {
        readonly HttpClient _client;
        readonly string endpoint;
        public TaskControllerIntegrationTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
            endpoint = "api/task/";
        }

        [Fact]
        public async Task DeleteTask_WhenTaskExist_Than204NoContent()
        {
            var task = new TaskDTO
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = 1,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 1,
                TaskStateId = 1,
            };

            var createdTaskResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(task), Encoding.UTF8, "application/json"));
            var createdTaskResposeContent = await createdTaskResponse.Content.ReadAsStringAsync();
            var createdTask = JsonConvert.DeserializeObject<TaskDTO>(createdTaskResposeContent);

            var deletedTaskResponse = await _client.DeleteAsync(endpoint + createdTask.Id);

            Assert.Equal(HttpStatusCode.NoContent, deletedTaskResponse.StatusCode);
        }
    
        [Fact]
        public async Task DeleteTask_WhenTaskNotExist_Than404NotFound()
        {
            var task = new TaskDTO
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = 1,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 1,
                TaskStateId = 1,
            };

            var createdTaskResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(task), Encoding.UTF8, "application/json"));
            var createdTaskResposeContent = await createdTaskResponse.Content.ReadAsStringAsync();
            var createdTask = JsonConvert.DeserializeObject<TaskDTO>(createdTaskResposeContent);

            await _client.DeleteAsync(endpoint + createdTask.Id);
            var deletedTaskResponse = await _client.DeleteAsync(endpoint + createdTask.Id);

            Assert.Equal(HttpStatusCode.NotFound, deletedTaskResponse.StatusCode);
        }
    }
}
