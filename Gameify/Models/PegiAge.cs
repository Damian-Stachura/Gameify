using System.ComponentModel.DataAnnotations;

namespace Gamey.Models
{
    public class PegiAge
    {
        public byte Id { get; set; }

        [Required]
        [Range(3, 18, ErrorMessage = "Pegi age restrictions start at 3 and end at 18")]
        public byte Age { get; set; }
    }
}
