using Review_Website.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Review_Website.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string? PictureURL { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Genre Genre {  get; set; }

        public List<Review>? rewies { get; set; } = new();

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }

        public List<Actor_Movie>?  Actor_Movies { get; set; } = new();
    }
}
