namespace ShadowSlave.Shared.Helpers
{
    public class Tile
    {
        public char Symbol { get; set; } = '.'; // Default floor
        public string Color { get; set; } = "gray";
        public bool IsWalkable { get; set; } = true;
    }
}
