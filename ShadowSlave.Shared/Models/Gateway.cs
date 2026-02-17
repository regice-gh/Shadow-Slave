using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class Gateway
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Region { get; set; } = string.Empty;

        // --- Game Engine Logic Properties ---
        public bool IsActive { get; set; } = false;

        /// <summary>
        /// - Gateways allow return to the real world.
        /// If true, this gateway is used as a 'Spawn Point' or 'Home Base'.
        /// </summary>
        public bool IsAnchored { get; set; } = false;

        // --- N-Tier / Database Relationships ---
        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location? Location { get; set; }

        // A Gateway can be the anchor point for many Awakened humans.
        public virtual ICollection<Awakened> AnchoredAwakeneds { get; set; } = new List<Awakened>();
    }
}