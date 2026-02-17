using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShadowSlave.Shared.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Realm { get; set; } = "Dream Realm";

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        public bool IsDeathZone { get; set; } = false;

        public bool HasGateway { get; set; } = false;

        [Required]
        public LocationType Type { get; set; }

        // --- N-Tier / Database Relationships ---
        public virtual ICollection<Gateway> Gateways { get; set; } = new List<Gateway>();
    }
}