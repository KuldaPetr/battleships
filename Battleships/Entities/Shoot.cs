using System.Collections.Generic;
using Battleships.Common;

namespace Battleships.Entities
{
    public class Shoot : ICollidable
    {
        public Shoot(Dimension dimension)
        {
            _coordinates.Add(dimension, false);
        }

        private readonly IDictionary<Dimension, bool> _coordinates = new Dictionary<Dimension, bool>(1);
        public IReadOnlyDictionary<Dimension, bool> Coordinates => (IReadOnlyDictionary<Dimension, bool>)_coordinates;
    }
}