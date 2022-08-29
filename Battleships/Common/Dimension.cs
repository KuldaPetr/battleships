using System.Collections.Generic;
using System.Text.RegularExpressions;
using Battleships.Exceptions;

namespace Battleships.Common
{
    public struct Dimension
    {
        public Dimension(int x, int y)
        {
            X = x;
            Y = y;
        }

        public readonly int X;
        public readonly int Y;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">Except format X:Y</param>
        /// <returns></returns>
        public static Dimension Parse(string input)
        {
            var pattern = "^([0-9]{1,})\\:([0-9]{1,})$";

            if (!Regex.IsMatch(input, pattern, RegexOptions.Singleline))
                throw new DimensionStringIsInIncorrectFormatException();

            var match = Regex.Match(input, pattern, RegexOptions.Singleline);
            return new Dimension(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value));
        }

        public static IEnumerable<Dimension> Parse(string[] inputs)
        {
            var result = new HashSet<Dimension>(inputs.Length);

            foreach (var input in inputs)
            {
                result.Add(Parse(input));
            }

            return result;
        }

        public override string ToString()
        {
            return $"{X}:{Y}";
        }
    }
}