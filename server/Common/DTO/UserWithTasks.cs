using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTO
{
    public class UserWithTasks
    {
        public UserDTO User { get; set; }
        public IEnumerable<TaskDTO> Tasks { get; set; }
    }
}
