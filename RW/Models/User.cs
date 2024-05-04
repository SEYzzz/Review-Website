using System.ComponentModel.DataAnnotations;

namespace Review_Website.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? login { get; set; }
        public string? password { get; set; }

        public string Name { get; set; }
        public string? UserPictureURL { get; set; }

        public List<Review>? reviews { get; set; } = new();
    }
}
