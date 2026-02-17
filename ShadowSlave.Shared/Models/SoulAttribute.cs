using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class SoulAttribute
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        // --- Game Engine Logic Properties ---

        /// <summary>
        /// Used by the Logic Tier to categorize effects (e.g., "Combat", "Utility").
        /// </summary>
        public string Category { get; set; } = "Utility";

        /// <summary>
        /// A numerical value for the C# math. 
        /// E.g., if Name is "Stalwart", Value could be 20.0 (representing 20% defense).
        /// </summary>
        public double Value { get; set; } = 0.0;

        // --- N-Tier / Database Relationships ---

        // Attributes can belong to an Awakened character...
        public int? AwakenedId { get; set; }
        [ForeignKey("AwakenedId")]
        public virtual Awakened? Awakened { get; set; }

        // ...OR to an Echo/Shadow.
        public int? EchoId { get; set; }
        [ForeignKey("EchoId")]
        public virtual Echo? Echo { get; set; }
    }
}