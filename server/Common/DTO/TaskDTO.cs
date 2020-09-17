using System;

namespace Common.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public int TaskStateId { get; set; }
        public int ProjectId { get; set; }
        public int PerformerId { get; set; }
    }
}
