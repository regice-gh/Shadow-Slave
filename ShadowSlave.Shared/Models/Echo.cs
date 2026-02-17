using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class Echo
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Saint"
        public string OriginalName { get; set; } = string.Empty; // e.g., "Stone Saint"

        public SoulRank Rank { get; set; }
        public SoulClass Class { get; set; }

        // Special flag for Sunny's ability to turn Echoes into growing Shadows
        public bool IsShadow { get; set; }

        public int OwnerId { get; set; } // FK to Awakened
        public List<Attribute>? Attributes { get; set; } // [Stalwart], [Underworld Armament] [20]
    }
}
