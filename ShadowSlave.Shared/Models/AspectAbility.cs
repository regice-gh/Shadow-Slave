using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class AspectAbility
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Shadow Control", "Soul Flame"
        public SoulRank UnlockRank { get; set; } // Dormant, Awakened, Ascended, etc.
        public string EffectDescription { get; set; } = string.Empty;

        public int AspectId { get; set; }
    }
}
