using Padawan.WebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Padawan.WebApi.Model
{
    [Table("Users")]
    public class User : Entity
    {
        [StringLength(75)]
        public string Name { get; set; }
        [Required]
        [StringLength(75)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
