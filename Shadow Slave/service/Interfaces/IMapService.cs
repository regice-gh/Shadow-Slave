using ShadowSlave.Shared.Helpers;
namespace Shadow_Slave.service.Interfaces
{
    public interface IMapService
    {
        Tile[,] GetMap();
        void MovePlayer(int dx, int dy);
        Point PlayerPos { get; }
    }
}
