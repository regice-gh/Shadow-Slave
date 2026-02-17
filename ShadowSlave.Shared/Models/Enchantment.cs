using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class Enchantment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        // --- Essence Mechanics ---
        public bool IsPassive { get; set; } = true;

        [Range(0, 500)]
        public int EssenceActivationCost { get; set; } = 0;

        // --- Logic Tier Flags ---
        public bool IsCurse { get; set; } = false;

        // --- N-Tier / Database Relationships ---
        [Required]
        public int MemoryId { get; set; }

        [ForeignKey("MemoryId")]
        public virtual Memory? Memory { get; set; }
    }
}