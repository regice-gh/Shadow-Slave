using System.ComponentModel.DataAnnotations;

namespace ShadowSlave.Shared.Models
{
    public class Clan
    {
        [Key]
        public int Id { get; set; }

        // --- Basic Info ---
        [Required(ErrorMessage = "Clan name is required.")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        // --- Lore Properties (World Building) ---
        [MaxLength(100)]
        public string? SovereignName { get; set; }

        [MaxLength(100)]
        public string? MainCitadel { get; set; }
        public bool IsGreatClan { get; set; } = false;

        // --- Navigation Properties ---
        public virtual ICollection<Awakened> Members { get; set; } = new List<Awakened>();
    }
}