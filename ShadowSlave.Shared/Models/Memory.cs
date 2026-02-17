using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class Memory
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; } = string.Empty;

        // The Rank determines the quality/power (e.g., Ascended).
        public SoulRank Rank { get; set; }

        // The Tier determines the complexity/capacity (number of enchantments).
        // Source: [8]
        public int Tier { get; set; }

        // The physical form/category of the memory.
        public MemoryType Type { get; set; }

        // A Memory can hold multiple enchantments based on its Tier.
        public List<Enchantment> Enchantments { get; set; } = new();
    }
}
