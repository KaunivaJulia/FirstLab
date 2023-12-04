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
        public void IsSumValid()
        {
            var firstPart = new FirstPart(100);
            var arr = firstPart.Vector.ToArray();

            var maxIndex = Array.IndexOf(arr, arr.Max());

            int sum = 0;
            for (int i = maxIndex + 1; i < arr.Length; i++)
            {

                sum += arr[i];

            }


            var prov = firstPart.GetSumAfterMax();

            //var mul = arr.Skip(minIndex + 1).Take(maxIndex - minIndex - 1).ToList();
            if (maxIndex == arr.Length - 1)
            {
                Assert.Equal(0, prov);
            }
            else
            {
                Assert.Equal(, prov);
            }
        }

        
        [Fact]
        public void IsSortedByAscending()
        {
            
        }


    }
}