using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Padawan.WebApi.Domain.Models
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? Update { get; set; }
        public bool IsDeleted { get; set; }
    }
}
