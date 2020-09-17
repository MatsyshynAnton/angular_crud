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
    public class UserControllerIntegrationTest: IClassFixture<CustomWebApplicationFactory>
    {
        readonly HttpClient _client;
        readonly string endpoint;

        public UserControllerIntegrationTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
            endpoint = "api/user/";
        }

        [Fact]
        public async Task DeleteUser_WhenUserExist_Than204NoContext()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            var createUserResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var createUserContent = await createUserResponse.Content.ReadAsStringAsync();
            var createdUser = JsonConvert.DeserializeObject<UserDTO>(createUserContent);

            var task = new TaskDTO
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = createdUser.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 3,
            };

            var createdTaskResponse = await _client.PostAsync("api/task", new StringContent(JsonConvert.SerializeObject(task), Encoding.UTF8, "application/json"));
            var createdTaskContent = await createdTaskResponse.Content.ReadAsStringAsync();
            var createdTask = JsonConvert.DeserializeObject<TaskDTO>(createdTaskContent);

            var deleteUserRespose = await _client.DeleteAsync(endpoint + createdUser.Id);
            var getTaskResponse = await _client.GetAsync($"api/task/{createdTask.Id}");

            Assert.Equal(HttpStatusCode.NoContent, deleteUserRespose.StatusCode);
            Assert.Equal(HttpStatusCode.NotFound, getTaskResponse.StatusCode);
        }

        [Fact]
        public async Task DeleteUser_WhenUserNotExist_Than404NotFound()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            var createUserResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var createUserContent = await createUserResponse.Content.ReadAsStringAsync();
            var createdUser = JsonConvert.DeserializeObject<UserDTO>(createUserContent);

            await _client.DeleteAsync(endpoint + createdUser.Id);
            var deleteUserRespose = await _client.DeleteAsync(endpoint + createdUser.Id);

            Assert.Equal(HttpStatusCode.NotFound, deleteUserRespose.StatusCode);
        }
    
        [Fact]
        public async Task GetUserUnfinishedTasks_WhenAddUserAndTwoTasks_ThanResultTasksLength2()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            var createUserResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var createUserContent = await createUserResponse.Content.ReadAsStringAsync();
            var createdUser = JsonConvert.DeserializeObject<UserDTO>(createUserContent);

            var task1 = new TaskDTO
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = createdUser.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 1,
                TaskStateId = 1,
            };

            var task2 = new TaskDTO
            {
                Name = "2nd task name",
                Description = "2nd task description",
                PerformerId = createdUser.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 2,
            };

            await _client.PostAsync("api/task", new StringContent(JsonConvert.SerializeObject(task1), Encoding.UTF8, "application/json"));
            await _client.PostAsync("api/task", new StringContent(JsonConvert.SerializeObject(task2), Encoding.UTF8, "application/json"));

            var getUnfinishedTasksResponse = await _client.GetAsync($"{endpoint}unifinishedtasks/{createdUser.Id}");
            var getUnfinishedTasksResponseContent = await getUnfinishedTasksResponse.Content.ReadAsStringAsync();
            var unfinishedTasks = JsonConvert.DeserializeObject<TaskDTO[]>(getUnfinishedTasksResponseContent);

            Assert.Equal(2, unfinishedTasks.Length);
        }
    
        [Fact]
        public async Task GetUserUnfinishedTasks_WhenAddUserAndFinishedTasks_ThanResultTasksLength0()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            var createUserResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var createUserContent = await createUserResponse.Content.ReadAsStringAsync();
            var createdUser = JsonConvert.DeserializeObject<UserDTO>(createUserContent);

            var task1 = new TaskDTO
            {
                Name = "1st task name",
                Description = "1st task description",
                PerformerId = createdUser.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 1,
                TaskStateId = 3,
            };

            var task2 = new TaskDTO
            {
                Name = "2nd task name",
                Description = "2nd task description",
                PerformerId = createdUser.Id,
                FinishedAt = DateTime.Parse("01/01/2020"),
                ProjectId = 2,
                TaskStateId = 3,
            };

            await _client.PostAsync("api/task", new StringContent(JsonConvert.SerializeObject(task1), Encoding.UTF8, "application/json"));
            await _client.PostAsync("api/task", new StringContent(JsonConvert.SerializeObject(task2), Encoding.UTF8, "application/json"));

            var getUnfinishedTasksResponse = await _client.GetAsync($"{endpoint}unifinishedtasks/{createdUser.Id}");
            var getUnfinishedTasksResponseContent = await getUnfinishedTasksResponse.Content.ReadAsStringAsync();
            var unfinishedTasks = JsonConvert.DeserializeObject<TaskDTO[]>(getUnfinishedTasksResponseContent);

            Assert.Empty(unfinishedTasks);
        }
    
        [Fact]
        public async Task GetUserUnfinishedTasks_WhenUserNotExist_Than404NotFound()
        {
            var user = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
            };

            var createUserResponse = await _client.PostAsync(endpoint, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var createUserContent = await createUserResponse.Content.ReadAsStringAsync();
            var createdUser = JsonConvert.DeserializeObject<UserDTO>(createUserContent);

            await _client.DeleteAsync(endpoint + createdUser.Id);

            var getUnfinishedTasksResponse = await _client.GetAsync($"{endpoint}unifinishedtasks/{createdUser.Id}");

            Assert.Equal(HttpStatusCode.NotFound, getUnfinishedTasksResponse.StatusCode);
        }
    }
}
