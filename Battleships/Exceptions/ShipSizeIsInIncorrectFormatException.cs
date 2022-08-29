using System;
using System.Runtime.Serialization;

namespace Battleships.Exceptions
{
    public sealed class ShipSizeIsInIncorrectFormatException : Exception
    {
        public ShipSizeIsInIncorrectFormatException()
        {
        }

        public ShipSizeIsInIncorrectFormatException(string message) : base(message)
        {
        }

        public ShipSizeIsInIncorrectFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ShipSizeIsInIncorrectFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}