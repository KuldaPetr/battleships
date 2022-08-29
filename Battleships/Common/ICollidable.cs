using System.Collections.Generic;

namespace Battleships.Common
{
    public interface ICollidable
    {
        IReadOnlyDictionary<Dimension, bool> Coordinates { get; }

    }
}