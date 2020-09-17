using DataAccessLayer.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class User: BaseEntity
    {
        public override int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisteredAt { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }
}
