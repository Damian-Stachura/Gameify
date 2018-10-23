﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Gamey.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Producer { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public PegiAge PegiAge { get; set; }

        [Required]
        [Display(Name = "Pegi Age Category")]
        public byte PegiAgeId { get; set; }

        public PegiContent PegiContent { get; set; }

        [Required]
        [Display(Name = "Pegi Content Flag")]
        public byte PegiContentId { get; set; }

        [Required]
        [Display(Name = "Platforms")]
        public string AvailableOnPlatforms { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        [Range(0, 50, ErrorMessage = "You cannot insert numbers less than 0 or more than 50")]
        [Display(Name = "Available Copies")]
        public int NumberAvailable { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "The rating marks range from 0 to 10")]
        public byte Rating { get; set; }

    }
}
