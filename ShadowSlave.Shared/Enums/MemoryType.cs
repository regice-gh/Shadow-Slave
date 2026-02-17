namespace ShadowSlave.Shared.Enums
{
    public enum MemoryType
    {
        Weapon = 1,      // Swords, Bows, Spears (e.g., Midnight Shard)
        Armor = 2,       // Plate, Chainmail (e.g., Starlight Legion Armor)

        // Rare accessories with unique/powerful enchantments but no practical physical value.
        Charm = 3,       // Amulets, Talismans (e.g., Blood Blossom, Essence Pearl)

        // Utility items acting as the foundation of an arsenal.
        Tool = 4,        // Also known as Utility Memories (e.g., Covetous Coffer, Endless Spring)

        // Rare types less useful than armor but can be worn alongside it.
        Garment = 5,     // Clothes, Mantles (e.g., Ananke's Mantle, Puppeteer's Shroud)

        // Consumable memories that impart hereditary attributes.
        Lineage = 6      // (e.g., Drop of Ichor) [2]
    }
}
