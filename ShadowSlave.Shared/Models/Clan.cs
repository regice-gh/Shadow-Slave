namespace ShadowSlave.Shared.Models
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Valor"
        public string Description { get; set; } = string.Empty;
        public List<Awakened> Members { get; set; } = new();
    }
}
