using DataAccessLayer.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Project: BaseEntity
    {
        public override int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        [MinLength(15)]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public int? AuthorId { get; set; }
        public User Author { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public IEnumerable<Task> Tasks { get; set; }
    }
}
