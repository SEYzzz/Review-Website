﻿using System.ComponentModel.DataAnnotations;

namespace Review_Website.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        [Display(Name = "Picture")]
        public string ProfilePictureURL { get; set; }

        public List<Movie>? Movies { get; set; } = new();

    }
}
