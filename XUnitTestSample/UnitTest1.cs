using System;
using Xunit;
using ServiceManagerBll;

namespace XUnitTestSample
{
    public class UnitTest1 : IDisposable
    {

        public UnitTest1()
        {
            // Ccode to initialize the test class
        }

        [Theory]
        [InlineData(5, 4)]
        [InlineData(3, 3)]
        public void TestSum(int A, int B)
        {
            var sc = new ServiceClass();
            int sum = sc.SumIntNumbers(A, B);
            int res = A + B;
            Assert.Equal<int>(res, sum);
            Assert.InRange<int>(5, 1, 10);
        }

        [Fact]
        public void AddMethod_Numbers_Success()
        {
            var sc = new ServiceClass();
            var result = sc.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            var sc = new ServiceClass();
            var result = sc.Subtract(4, 3);

            Assert.Equal(1, result);
        }

        [Fact]
        public void MultiplyMethod_Numbers_Success()
        {
            var sc = new ServiceClass();
            var result = sc.Multiply(4, 3);

            Assert.Equal(12, result);
        }

        [Fact]
        public void DivideMethod_Numbers_Success()
        {
            var sc = new ServiceClass();
            var result = sc.Divide(4, 2);

            Assert.Equal(2, result);
        }

        public void Dispose()
        {
            // code to clean up the test class.
        }

    }
}
