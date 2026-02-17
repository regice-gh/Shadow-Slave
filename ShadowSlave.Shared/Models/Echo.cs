using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class Echo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        // --- The Link to the Source Creature ---
        [Required]
        public int SourceCreatureId { get; set; }

        [ForeignKey("SourceCreatureId")]
        public virtual NightmareCreature? SourceCreature { get; set; }
        //var newEcho = new Echo {
        //SourceCreatureId = slainMonster.Id,
        //Rank = slainMonster.Rank, // The Echo starts at the monster's rank
        //Class = slainMonster.Class,
        //Name = slainMonster.Name
        //};

        // --- Current Stats ---
        // We keep these here because Shadows can evolve BEYOND their original creature
        public SoulRank Rank { get; set; }
        public SoulClass Class { get; set; }

        public bool IsShadow { get; set; } = false;
        public int SoulFragments { get; set; }

        [Required]
        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual Awakened? Owner { get; set; }

        public virtual ICollection<SoulAttribute> Attributes { get; set; } = new List<SoulAttribute>();
    }
}