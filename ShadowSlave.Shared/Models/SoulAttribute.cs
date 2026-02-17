namespace ShadowSlave.Shared.Models
{
    public class SoulAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Fated"
        public string Description { get; set; } = string.Empty;

        // Attributes can belong to Echoes or Awakened
        // For simplicity in this context, we linked them to Echoes in the OnModelCreating
        public int? EchoId { get; set; }
        public int? AwakenedId { get; set; }
    }
}
