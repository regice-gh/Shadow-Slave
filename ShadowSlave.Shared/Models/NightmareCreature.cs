using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShadowSlave.Shared.Models
{
    public class NightmareCreature
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public SoulRank Rank { get; set; }

        [Required]
        public SoulClass Class { get; set; }

        [Required]
        [MaxLength(2000)]
        public string AbilitiesDescription { get; set; } = string.Empty;

        // --- Game Engine Logic: Combat Stats ---
        [Range(1, 1000000)]
        public int MaxHealth { get; set; } = 100;
        //ActualHealth = monster.MaxHealth * (int)monster.Class;.

        [Range(1, 100000)]
        public int AttackPower { get; set; } = 10;

        // --- Game Engine Logic: Loot Table ---
        [Range(0, 10000)]
        public int SoulShardsDrop { get; set; } = 1;

        /// <summary>
        /// Source: [1.3.1] - Memories and Echoes have low drop rates.
        /// Using a double (0.0 to 1.0) allows the Engine to roll for loot.
        /// </summary>
        [Range(0.0, 1.0)]
        public double MemoryDropRate { get; set; } = 0.05; // 5% chance

        [Range(0.0, 1.0)]
        public double EchoDropRate { get; set; } = 0.01; // 1% chance
        //if (Random.Shared.NextDouble() <= monster.MemoryDropRate) { awardLoot(); }

        // --- N-Tier / Database Relationships ---

        // One monster type can have dropped many specific Echo instances in history
        public virtual ICollection<Echo> DroppedEchoes { get; set; } = new List<Echo>();

        // One monster type can have dropped many specific Memory instances
        public virtual ICollection<Memory> DroppedMemories { get; set; } = new List<Memory>();
    }
}