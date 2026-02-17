using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class Awakened
    {
        public int Id { get; set; }

        // Basic Info
        public string Name { get; set; } = string.Empty; // e.g., "Sunless"

        // Source: [4], [5] - True Names give power and influence fate.
        public string? TrueName { get; set; } // Nullable (e.g., "Lost from Light")

        // Progression Stats
        public SoulRank Rank { get; set; } // e.g., Transcendent
        public SoulClass Class { get; set; } // e.g., Terror (for Divine Aspect holders)

        // Source: [6], [7] - Fragments determine progress to next rank/class.
        public int SoulFragments { get; set; }
        public int MaxFragments { get; set; } // 1000, 2000, etc.
        public int SoulCores { get; set; } // 1 for normal, up to 7 for Divine Aspects [8]

        // Navigation Properties (Foreign Keys)
        public int AspectId { get; set; }
        public Aspect? Aspect { get; set; }

        public int FlawId { get; set; }
        public Flaw? Flaw { get; set; }

        // Source: [9] - Clan affiliation (e.g., Valor, Immortal Flame)
        public int? ClanId { get; set; }
        public Clan? Clan { get; set; }

        // Inventory & Summons
        public int MemoryId { get; set; }
        public List<Memory>? Memories { get; set; } // An Awakened can have multiple Memories (inventory)
        public int EchoId { get; set; }
        public List<Echo>? Echoes { get; set; } // An Awakened can have multiple Echoes (summons)
    }
}
