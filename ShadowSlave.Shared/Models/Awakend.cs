using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class Awakened
    {
        [Key]
        public int Id { get; set; }

        // --- Basic Info ---
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? TrueName { get; set; }

        // --- Progression Stats ---
        [Required]
        public SoulRank Rank { get; set; } = SoulRank.Dormant;

        [Required]
        public SoulClass Class { get; set; } = SoulClass.Beast;

        [Range(0, 100000)]
        public int SoulFragments { get; set; } = 0;
        public int MaxFragments => (int)Rank * 1000;

        [Range(1, 7)]
        public int SoulCores { get; set; } = 1;

        // --- Essence System ---
        public int CurrentEssence { get; set; }
        public int MaxEssence => SoulCores * 100; // Each Soul Core grants 100 Essence. This is a simple formula, but you can expand it with bonuses from Aspects, Flaws, or Memory traits later on.

        // --- Navigation Properties ---
        [Required]
        public int AspectId { get; set; }
        [ForeignKey("AspectId")]
        public virtual Aspect? Aspect { get; set; }

        [Required]
        public int FlawId { get; set; }
        [ForeignKey("FlawId")]
        public virtual Flaw? Flaw { get; set; }

        public int? ClanId { get; set; }
        [ForeignKey("ClanId")]
        public virtual Clan? Clan { get; set; }

        public int? GatewayId { get; set; }
        [ForeignKey("GatewayId")]
        public virtual Gateway? Gateway { get; set; }

        // --- Collections ---
        public virtual ICollection<Memory> Memories { get; set; } = new List<Memory>();
        public virtual ICollection<Echo> Echoes { get; set; } = new List<Echo>();
    }
}