using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class Aspect
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Shadow Slave"
        public string Description { get; set; } = string.Empty; // Flavor text describing the Aspect's theme and abilities.
        public SoulRank AspectRank { get; set; } // Divine, Sacred, etc. [11]

        // One-to-Many: An Aspect has multiple abilities unlocking at different ranks
        public List<AspectAbility> Abilities { get; set; } = new();
    }
}
