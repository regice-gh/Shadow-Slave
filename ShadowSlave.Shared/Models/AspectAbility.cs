using ShadowSlave.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowSlave.Shared.Models
{
    public class AspectAbility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        //UnlockRank: This is critical for the Shadow Slave feel. When a player "Ascends" from Sleeper (Dormant) to Awakened, your UI can filter this list:
        //var availableAbilities = allAbilities.Where(a => a.UnlockRank <= player.CurrentRank);
        public SoulRank UnlockRank { get; set; }

        [Required]
        [MaxLength(2000)]
        public string EffectDescription { get; set; } = string.Empty;


        [Range(0, 1000)]
        //if (player.Essence >= ability.EssenceCost) { useAbility(); }
        public int EssenceCost { get; set; } = 0;

        public bool IsPassive { get; set; } = false;


        [Required]
        public int AspectId { get; set; }

        [ForeignKey("AspectId")]
        //It allows you to say myAbility.Aspect.Name to see which Aspect it belongs to without doing a second database search
        public virtual Aspect? Aspect { get; set; }
    }
}