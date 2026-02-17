namespace ShadowSlave.Shared.Models
{
    public class Enchantment
    {
        public int Id { get; set; }

        // The name of the enchantment (e.g., [Unbroken], [Underworld Armament])
        public string Name { get; set; } = string.Empty;

        // The lore description of what the enchantment does.
        public string Description { get; set; } = string.Empty;

        // Source: [4] - "Only the weakest enchantments could be activated passively... 
        // everything else would only function when saturated by the flow of essence."
        public bool IsPassive { get; set; }

        // Some enchantments, like [King's Resentment] or [Cursed], have negative effects.
        // Source: [6], [7]
        public bool IsCurse { get; set; }

        // Foreign Key: The Tier of the Memory dictates how many enchantments it can hold.
        // A Tier 4 Memory can hold more enchantments than a Tier 1.
        // Source: [8]
        public int MemoryId { get; set; }
        public Memory? Memory { get; set; }
    }
}
