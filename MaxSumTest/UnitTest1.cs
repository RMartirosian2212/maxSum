using System;
using Xunit;
using System.Text;
using Max;

namespace MaxSumTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string path = @"file.txt";
            double expected = 3;
            Calculation a = new Calculation();
            double result = a.calc(path);
            Assert.Equal(expected, result);
        }
    }
}
