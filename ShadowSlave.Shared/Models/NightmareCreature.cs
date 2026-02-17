using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class NightmareCreature
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Winter Beast"
        public SoulRank Rank { get; set; } // Corrupted, Great, etc.
        public SoulClass Class { get; set; } // Titan, Terror, etc.

        // Abilities/Traits (e.g., Mind attacks, Physical immunity)
        public string AbilitiesDescription { get; set; } = string.Empty;

        // Drop Table logic
        public int SoulShardsDrop { get; set; }
        public bool HasMemoryDrop { get; set; }
    }
}
