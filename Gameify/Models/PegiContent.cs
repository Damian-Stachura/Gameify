using System.ComponentModel.DataAnnotations;

namespace Gamey.Models
{
    public class PegiContent
    {
        public byte Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
