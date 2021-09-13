using System;

namespace Padawan.WebApi.Api.Service.ViewModels
{
    public class PhotoViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
