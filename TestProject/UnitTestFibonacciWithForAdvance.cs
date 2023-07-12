using CalculatorFibonacci;

namespace UnitTest_Fibonacci
{
    public class UnitTestFibonacciWithForAdvance
    {
        [Test]
        [TestCase(-1)]
        [TestCase(93)]
        public void testFactorialGivenWrongArguementThrowException(int n)
        {
            Assert.Throws<ArgumentException>(() => { Fibonacci.FibonacciWithFor(-5); });
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(5, 5)]
        [TestCase(9, 34)]
        [TestCase(20, 6765)]
        public void testFactorialGivenRightArgumentReturnWell(int n, long result)
        {
            Assert.That(Fibonacci.FibonacciWithFor(n), Is.EqualTo(result));
        }
    }
}