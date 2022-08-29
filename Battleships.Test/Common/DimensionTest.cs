using System;
using Battleships.Common;
using Battleships.Exceptions;
using FluentAssertions;
using Xunit;

namespace Battleships.Test.Common
{
    public class DimensionTest
    {
        [Fact]
        public void Dimension_Parse_Success_4x4()
        {
            var input = "4:4";

            var expectation = new Dimension(4, 4);

            Dimension.Parse(input).Should().Be(expectation);

            
        }

        [Fact]
        public void Dimension_Parse_Error_WrongFormat()
        {
            var input = "4:abcd";

            Action action = () => Dimension.Parse(input);

            var exception = Assert.Throws<DimensionStringIsInIncorrectFormatException>(action);

            Assert.IsType<DimensionStringIsInIncorrectFormatException>(exception);
        }

        [Fact]
        public void Dimension_ParseMoreInputs_Success()
        {
            var inputs = new[] { "1:2", "3:3", "4:5", "6:7" };

            var expectation = new[] { new Dimension(1, 2), new Dimension(3, 3), new Dimension(4, 5), new Dimension(6, 7) };

            Dimension.Parse(inputs).Should().BeEquivalentTo(expectation);
        }

        [Fact]
        public void Dimension_ParseMoreInputs_Error_WrongFormat()
        {
            var inputs = new[] { "1:2", "A:B", "4:5", "6:7" };

            Action action = () => Dimension.Parse(inputs);

            var exception = Assert.Throws<DimensionStringIsInIncorrectFormatException>(action);

            Assert.IsType<DimensionStringIsInIncorrectFormatException>(exception);
        }

    }
}