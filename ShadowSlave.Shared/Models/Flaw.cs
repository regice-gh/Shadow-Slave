namespace ShadowSlave.Shared.Models
{
    public class Flaw
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Clear Conscience"
        public string Description { get; set; } = string.Empty; // "You cannot lie."
    }
}
