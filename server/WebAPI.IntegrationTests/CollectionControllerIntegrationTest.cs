using Common.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebAPI.IntegrationTests
{
    public class CollectionControllerIntegrationTest: IClassFixture<CustomWebApplicationFactory>
    {
        readonly HttpClient _client;
        readonly string endpoint;

        public CollectionControllerIntegrationTest(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
            endpoint = "api/collection";
        }

        [Fact]
        public async Task GetTeamsWithUsers_WhenAddUserAtLeast10YearsOldAndUser_ThanResultMembersLength1()
        {
            var team = new TeamDTO
            {
                Name = "party v minecrafte",
                CreatedAt = DateTime.Now
            };

            var createdTeamResponse = await _client.PostAsync("api/team", new StringContent(JsonConvert.SerializeObject(team), Encoding.UTF8, "application/json"));
            var createdTeamResponseContent = await createdTeamResponse.Content.ReadAsStringAsync();
            var createdTeam = JsonConvert.DeserializeObject<TeamDTO>(createdTeamResponseContent);

            var user15YearsOld = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
                Birthday = DateTime.Parse("01/01/2005"),
                TeamId = createdTeam.Id
            };

            var user = new UserDTO
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
                TeamId = createdTeam.Id
            };

            await _client.PostAsync("api/user", new StringContent(JsonConvert.SerializeObject(user15YearsOld), Encoding.UTF8, "application/json"));
            await _client.PostAsync("api/user", new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));

            var collectionResponse = await _client.GetAsync($"{endpoint}/teamswithusers");
            var collectionResponseContent = await collectionResponse.Content.ReadAsStringAsync();
            var collection = JsonConvert.DeserializeObject<IEnumerable<TeamWithUsersDTO>>(collectionResponseContent);

            Assert.Single(collection.Single(t => t.TeamId == createdTeam.Id).Members);
        }
    
        [Fact]
        public async Task GetTeamsWithUsers_WhenAllUsersYoungerThan10_ThanTeamNotIncludesToCollection()
        {
            var team = new TeamDTO
            {
                Name = "party v minecrafte",
                CreatedAt = DateTime.Now
            };

            var createdTeamResponse = await _client.PostAsync("api/team", new StringContent(JsonConvert.SerializeObject(team), Encoding.UTF8, "application/json"));
            var createdTeamResponseContent = await createdTeamResponse.Content.ReadAsStringAsync();
            var createdTeam = JsonConvert.DeserializeObject<TeamDTO>(createdTeamResponseContent);

            var user1 = new UserDTO
            {
                FirstName = "Anton",
                LastName = "Matsyshyn",
                Email = "anton.matsyshyn@outlook.com",
                Birthday = DateTime.Parse("01/01/2015"),
                TeamId = createdTeam.Id
            };

            var user2 = new UserDTO
            {
                FirstName = "Svetlana",
                LastName = "Diode",
                Email = "sveta-diode@mail.ru",
                Birthday = DateTime.Parse("01/01/2013"),
                TeamId = createdTeam.Id
            };

            await _client.PostAsync("api/user", new StringContent(JsonConvert.SerializeObject(user1), Encoding.UTF8, "application/json"));
            await _client.PostAsync("api/user", new StringContent(JsonConvert.SerializeObject(user2), Encoding.UTF8, "application/json"));

            var collectionResponse = await _client.GetAsync($"{endpoint}/teamswithusers");
            var collectionResponseContent = await collectionResponse.Content.ReadAsStringAsync();
            var collection = JsonConvert.DeserializeObject<IEnumerable<TeamWithUsersDTO>>(collectionResponseContent);

            Assert.DoesNotContain(collection, t => t.TeamId == createdTeam.Id);
        }
    }
}
