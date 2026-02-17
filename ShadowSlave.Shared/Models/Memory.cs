using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class Memory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public SoulRank Rank { get; set; }

        [Required]
        [Range(1, 7)]
        public int Tier { get; set; }

        [Required]
        public MemoryType Type { get; set; }

        // --- Game Engine Logic Properties ---
        public bool IsSummoned { get; set; } = false;

        /// <summary>
        /// - Memories consume essence to manifest.
        /// Higher Rank/Tier memories should cost more to summon.
        /// </summary>
        public int SummonCost => (int)Rank * Tier * 10;
        //if (player.Essence >= memory.SummonCost)

        // --- N-Tier / Database Relationships ---
        [Required]
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Awakened? Owner { get; set; }

        /// <summary>
        /// Memories are dropped by Nightmare Creatures. 
        /// Linking this allows the UI to say "Dropped by a [Creature Name]".
        /// </summary>
        public int? SourceCreatureId { get; set; }

        [ForeignKey("SourceCreatureId")]
        public virtual NightmareCreature? SourceCreature { get; set; }

        public virtual ICollection<Enchantment> Enchantments { get; set; } = new List<Enchantment>();
    }
}