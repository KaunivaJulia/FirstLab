using FirstLab;
using Newtonsoft.Json.Linq;
using System;

namespace TestProject1
{
    public class FirstPartTests
    {
        [Theory]
        [InlineData(0, -10)]
        public void IsWrongLengthVectorCreatingFailed(int a, int b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new FirstPart(a));
            Assert.Throws<ArgumentOutOfRangeException>(() => new FirstPart(b));
        }

        [Fact]
        public void IsVectorContainsNegatives()
        {
            var firstPart = new FirstPart(100);
            Assert.Contains(firstPart.Vector, p => p < 0);
        }

        [Fact]
        public void IsCountValid()
        {
            var firstPart = new FirstPart(100);
            int A = 3;
            int B = 6;
            Assert.Equal(firstPart.GetCountOfArrayBetweenAB(A,B), firstPart.Vector.Where(i => i <= B & i>=A).Count());
        }
    
        
        [Fact]
       public void IsSortedByAscending()
{
    var firstPart = new FirstPart(100);
    firstPart.Sort();
    for (int i = 0; i < firstPart.Vector.Count - 1; i++)
    {
        Assert.True(Math.Abs(firstPart.Vector[i]) <= Math.Abs(firstPart.Vector[i + 1]));
    }


}
    }
}
