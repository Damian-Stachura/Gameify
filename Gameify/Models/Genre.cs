using System.ComponentModel.DataAnnotations;

namespace Gamey.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
