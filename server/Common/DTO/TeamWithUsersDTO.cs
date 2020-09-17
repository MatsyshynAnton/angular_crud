using System.Collections.Generic;

namespace Common.DTO
{
    public class TeamWithUsersDTO
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public IEnumerable<UserDTO> Members { get; set; }
    }
}
