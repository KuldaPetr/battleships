using System.Collections.Generic;
using System.Text.RegularExpressions;
using Battleships.Exceptions;

namespace Battleships.Common
{
    public struct ShipSize
    {
        public ShipSize(Dimension start, Dimension end)
        {
            Start = start;
            End = end;
        }

        public readonly Dimension Start;
        public readonly Dimension End;

        public static ShipSize Parse(string input)
        {
            var pattern = "^([0-9]{1,}\\:[0-9]{1,}),([0-9]{1,}\\:[0-9]{1,})$";

            if (!Regex.IsMatch(input, pattern)) throw new ShipSizeIsInIncorrectFormatException();

            var match = Regex.Match(input, pattern, RegexOptions.Singleline);

            var startDimension = Dimension.Parse(match.Groups[1].Value);
            var endDimension = Dimension.Parse(match.Groups[2].Value);

            return new ShipSize(startDimension, endDimension);
        }

        public static IEnumerable<ShipSize> Parse(string[] inputs)
        {
            var result = new HashSet<ShipSize>(inputs.Length);

            foreach (var input in inputs)
            {
                result.Add(Parse(input));
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Start.X}:{Start.Y},{End.X}:{End.Y}";
        }
    }
}