using System;
using System.Runtime.Serialization;

namespace Battleships.Exceptions
{
    public sealed class DimensionStringIsInIncorrectFormatException : Exception
    {
        public DimensionStringIsInIncorrectFormatException()
        {
        }

        public DimensionStringIsInIncorrectFormatException(string message) : base(message)
        {
        }

        public DimensionStringIsInIncorrectFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DimensionStringIsInIncorrectFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}