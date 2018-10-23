using Gameify.Dtos;
using Gamey.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gameify.ViewModels
{
    public class GameFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<PegiAge> PegiAges { get; set; }
        public IEnumerable<PegiContent> PegiContents { get; set; }

        public int? Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Producer { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Pegi Age Category")]
        public byte PegiAgeId { get; set; }

        [Required]
        [Display(Name = "Pegi Content Flag")]
        public byte PegiContentId { get; set; }

        [Required]
        [Display(Name = "Platforms")]
        public string AvailableOnPlatforms { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public int? Cost { get; set; }

        [Required]
        [Range(0, 50, ErrorMessage = "You cannot insert numbers less than 0 or more than 50")]
        [Display(Name = "Available Copies")]
        public int NumberAvailable { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "The rating marks range from 0 to 10")]
        public byte Rating { get; set; }

        public string Title
        {
            get { return Id != 0 ? "Edit game details" : "Add a new game"; }
        }

        public GameFormViewModel()
        {
            Id = 0;
        }

        public GameFormViewModel(GameDto gameDto)
        {
            Id = gameDto.Id;
            Name = gameDto.Name;
            Producer = gameDto.Producer;
            ReleaseDate = gameDto.ReleaseDate;
            GenreId = gameDto.GenreId;
            PegiAgeId = gameDto.PegiAgeId;
            PegiContentId = gameDto.PegiContentId;
            AvailableOnPlatforms = gameDto.AvailableOnPlatforms;
            Description = gameDto.Description;
            Cost = gameDto.Cost;
            NumberAvailable = gameDto.NumberAvailable;
            Rating = gameDto.Rating;
        }
    }
}
