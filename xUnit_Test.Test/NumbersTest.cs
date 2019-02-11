using System;
using Xunit;
using xUnit_Test.Enums;

namespace xUnit_Test.Test
{
    public class NumbersTest
    {
        [Fact]
        public void Fact()
        {
            var enumVal = Numbers.Two;
            Assert.Equal(Numbers.Two, enumVal);
        }

        [Theory]
        [InlineData((int)Numbers.Two)]
        public void IntTheory(int value)
        {
            Assert.Equal(Numbers.Two, (Numbers)value);
        }

        [Theory]
        [InlineData(Numbers.Two)]
        public void EnumTheory(Numbers value)
        {
            Assert.Equal(Numbers.Two, value);
        }

        [Theory]
        [InlineData(Numbers.Two, 2)]
        public void EnumTheory2(Numbers value, int value2)
        {
            Assert.Equal((int)value, value2);
        }

        [Theory]
        [InlineData(Numbers.Zero, 0)]
        [InlineData(Numbers.One, 1)]
        [InlineData(Numbers.Two, 2)]
        public void EnumTheory3(Numbers value, int value2)
        {
            Assert.Equal((int)value, value2);
        }
    }
}
