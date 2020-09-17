using DataAccessLayer.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Models
{
    public class TaskState:BaseEntity
    {
        public override int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string State { get; set; }
    }
}
