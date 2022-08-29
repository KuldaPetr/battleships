using FluentAssertions;
using Xunit;

namespace Battleships.Test
{
    public class GameTest
    {
        [Fact]
        public void Test_Play_NoSunked()
        {
            var ships = new[] { "3:2,3:5" };
            var guesses = new[] { "7:0", "3:3" };
            Game.Play(ships, guesses).Should().Be(0);
        }

        [Fact]
        public void Test_Play_NoSunkedButDamaged()
        {
            var ships = new[] { "3:2,3:5" };
            var guesses = new[] { "3:2", "3:3" };
            Game.Play(ships, guesses).Should().Be(0);
        }

        [Fact]
        public void Test_Play_Sunked()
        {
            var ships = new[] { "3:2,3:5" };
            var guesses = new[] { "3:2", "3:5", "3:3", "3:4" };
            Game.Play(ships, guesses).Should().Be(1);
        }

        [Fact]
        public void Test_Play_SunkedTwoShips()
        {
            var ships = new[] { "3:2,3:5","4:4,4:5" };
            var guesses = new[] { "3:2", "3:5", "3:3", "3:4","4:4","4:5" };
            Game.Play(ships, guesses).Should().Be(2);
        }
    }
}
