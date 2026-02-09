namespace ShadowSlave.Shared.Models
{
    public class NightmareCreature
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Core { get; set; }
        public string Rank { get; set; } = string.Empty;
        public int SoulEssense { get; set; }


        public int Health { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int ExperiencePoints { get; set; }
    }
}
