namespace ShadowSlave.Shared.Models
{
    public class AwakendHumans : Aspect
    {
        public string Name { get; set; } = string.Empty;
        public string? TrueName { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Core { get; set; }
        public string Rank { get; set; } = string.Empty;
        public int SoulEssense { get; set; }
    }
}
