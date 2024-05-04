using System.ComponentModel.DataAnnotations;

namespace Review_Website.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Bio {  get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string? ProfilePictureURL { get; set; }

        public List<Actor_Movie>? Actor_Movies { get; set; } = new();
    }
}
