using System;
using Xunit;
using static IndividualKata.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Negative1()
        {
            var Object = new PreInf();
            string result = Object.Method("");
            Assert.NotNull(result);

        }

        [Fact]
        public void Negative2()
        {
            var Object = new PreInf();
            string result = Object.Method("+/ab");
            Assert.NotNull(result);

        }

        [Fact]
        public void Positive1()
        {
            var Object = new PreInf();
            string result = Object.Method("+ab");
            Assert.Equal("a+b", result);

        }

        [Fact]
        public void Positive2()
        {
            var Object = new PreInf();
            string result = Object.Method("*+ab-cf");
            Assert.Equal("a+b*c-f", result);

        }
    }
}
