using Battleships.Common;

namespace Battleships.Entities
{
    public interface IShip : ICollidable
    {
        ShipSize Size { get; }

        bool IsDestroyed();
        bool Collide(ICollidable collidable);
    }
}