using DataAccessLayer.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Team: BaseEntity
    {
        public override int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
