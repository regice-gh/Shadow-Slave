using Shadow_Slave.service.Interfaces;
using ShadowSlave.Shared.Helpers;

namespace Shadow_Slave.service
{
    public class MapService : IMapService
    {
        private readonly int _width = 20;
        private readonly int _height = 10;
        private Tile[,] _map;
        public Point PlayerPos { get; private set; } = new(5, 5);

        public MapService()
        {
            _map = new Tile[_width, _height];
            // Initialize with empty tiles (Logic for generation goes here)
            for (int x = 0; x < _width; x++)
                for (int y = 0; y < _height; y++)
                    _map[x, y] = new Tile();
        }

        public Tile[,] GetMap() => _map;

        public void MovePlayer(int dx, int dy)
        {
            // Add "Business Logic" - e.g., don't walk through walls
            PlayerPos = new Point(PlayerPos.X + dx, PlayerPos.Y + dy);
        }
    }
}
