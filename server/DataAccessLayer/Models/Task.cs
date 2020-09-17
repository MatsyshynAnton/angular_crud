using DataAccessLayer.Models.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Task: BaseEntity
    {
        public override int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(20)]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public int TaskStateId { get; set; }
        public TaskState TaskState { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int PerformerId { get; set; }
        public User Performer { get; set; }
    }
}
