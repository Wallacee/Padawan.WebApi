using Padawan.WebApi.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Padawan.WebApi.Model
{
    [Table("Photos")]

    public class Photo : Entity
    {
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        [Required]
        [StringLength(1000)]
        public string Url { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public bool AllowComments { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
