using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace TestMultiBracketValidation
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}[]()", true)]
        [InlineData("{}[](", false)]
        [InlineData("{}[()", false)]
        [InlineData("{[]()", false)]
        [InlineData("{[]}()", true)]
        [InlineData("({[]})", true)]
        [InlineData("{{}[]}", true)]
        [InlineData("{", false)]
        [InlineData(null, false)]
        public void Test1(string input, bool expected)
        {
            Assert.Equal(expected, Validate(input));
        }
    }
}
