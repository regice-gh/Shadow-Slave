using ShadowSlave.Shared.Enums;

namespace ShadowSlave.Shared.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Godgrave", "Falcon Scott"
        public string Realm { get; set; } = string.Empty; // "Dream Realm" or "Waking World"
        public bool IsDeathZone { get; set; } // [25]
        public bool HasGateway { get; set; } // [26]

        // Hierarchy: Godgrave is a Region, Bastion is a Citadel
        public LocationType Type { get; set; }
    }
}
