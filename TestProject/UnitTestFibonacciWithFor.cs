using CalculatorFibonacci;

namespace UnitTest_Fibonacci
{
    public class UnitTestFibonacciWithFor
    {

        [Test]
        public void testFactorialGivenRightArgumentReturnWell()
        {
            //Cách viết 1:
            Assert.AreEqual(0, Fibonacci.FibonacciWithFor(0));
            Assert.AreEqual(1, Fibonacci.FibonacciWithFor(1));
            Assert.AreEqual(1, Fibonacci.FibonacciWithFor(2));
            Assert.AreEqual(2, Fibonacci.FibonacciWithFor(3));

            //Cách viết 2
            Assert.That(Fibonacci.FibonacciWithFor(4), Is.EqualTo(3));
            Assert.That(Fibonacci.FibonacciWithFor(5), Is.EqualTo(5));
            Assert.That(Fibonacci.FibonacciWithFor(20), Is.EqualTo(6765));
            Assert.That(Fibonacci.FibonacciWithFor(40), Is.EqualTo(102334155));
        }

        [Test]
        public void testFactorialGivenWrongArguementThrowException()
        {
            Assert.Throws<ArgumentException>(() => { Fibonacci.FibonacciWithFor(-1); });
            Assert.Throws<ArgumentException>(() => { Fibonacci.FibonacciWithFor(93); });
        }
    }
}