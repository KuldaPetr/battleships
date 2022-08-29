using System.Collections.Generic;
using System.Linq;
using Battleships.Common;

namespace Battleships.Entities
{
    public abstract class Ship : IShip
    {
        protected Ship(ShipSize shipSize)
        {
            Size = shipSize;

            var start = shipSize.Start;
            var end = shipSize.End;

            var collectionSize = (end.X - start.Y) * (end.Y - start.Y);
            _coordinates = new Dictionary<Dimension, bool>(collectionSize);


            for (var y = start.Y; y <= end.Y; y++)
            {
                for (var x = start.X; x <= end.X; x++)
                {
                    _coordinates.Add(new Dimension(x, y), false);
                }
            }

        }

        public ShipSize Size { get; }

        private readonly IDictionary<Dimension, bool> _coordinates;
        public IReadOnlyDictionary<Dimension, bool> Coordinates { get; }

        public bool Collide(ICollidable collidable)
        {
            var anySuccess = false;
            foreach (var coordination in collidable.Coordinates.Keys)
            {
                if (_coordinates.ContainsKey(coordination))
                {
                    _coordinates[coordination] = true;
                    anySuccess = true;
                }
            }

            return anySuccess;
        }

        public bool IsDestroyed()
        {
            return _coordinates.Values.All(q => q);
        }

    }
}