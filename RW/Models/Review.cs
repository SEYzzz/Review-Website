using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Review_Website.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        public string? Text { get; set; }

        public IdentityUser? User { get; set; }

        public DateTime date { get; set; }
    }
}
