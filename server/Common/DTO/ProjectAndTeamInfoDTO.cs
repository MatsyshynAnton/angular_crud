using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DTO
{
    public class ProjectAndTeamInfoDTO
    {
        public ProjectDTO Project { get; set; }
        public TaskDTO LongestTask { get; set; }
        public TaskDTO ShortestTask { get; set; }
        public int TeammatesCount { get; set; }
    }
}
