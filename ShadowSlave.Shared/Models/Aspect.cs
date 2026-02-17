using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShadowSlave.Shared.Models
{
    public class Aspect
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Every Aspect must have a name.")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "A description is required for flavor text.")]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, 7)]
        public SoulRank AspectRank { get; set; }


        [MaxLength(7)]
        public string DisplayColorHex { get; set; } = "#808080";

        public virtual List<AspectAbility> Abilities { get; set; } = new();
    }
}