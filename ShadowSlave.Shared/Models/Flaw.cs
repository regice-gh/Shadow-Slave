using System.ComponentModel.DataAnnotations;

namespace ShadowSlave.Shared.Models
{
    public class Flaw
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
        /// Helps the Engine know if this Flaw is purely narrative (Dialogue) 
        /// or mechanical (Combat/Stats).
        /// </summary>
        public bool IsMechanical { get; set; } = false;

        /// <summary>
        /// For mechanical flaws, this could be a percentage reduction in a stat 
        /// (e.g., -20% Health or -50% Essence recovery).
        /// </summary>
        public double PenaltyMagnitude { get; set; } = 0.0;

        // --- N-Tier / Relationship ---
        // A Flaw usually belongs to one Awakened character.
        public virtual Awakened? Owner { get; set; }
    }
}