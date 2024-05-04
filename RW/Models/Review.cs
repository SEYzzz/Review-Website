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

        public User User { get; set; }

    }
}
