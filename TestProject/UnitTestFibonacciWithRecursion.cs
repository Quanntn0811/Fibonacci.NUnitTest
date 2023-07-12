using CalculatorFibonacci;

namespace UnitTest_Fibonacci
{
    public class UnitTestFibonacciWithRecursion
    {
        [Test]
        public void testFactorialGivenRightArgumentReturnFaill()
        {
            //Expected Fibonacci(1) = 0 but Actual Fibonacci(1) = 1 => Test Fail
            Assert.That(Fibonacci.FibonacciWithRecursion(0), Is.EqualTo(1));
        }

        [Test]
        public void testFactorialGivenRightArgumentReturnWell()
        {
            //Cách viết 1:
            Assert.AreEqual(0, Fibonacci.FibonacciWithRecursion(0));
            Assert.AreEqual(1, Fibonacci.FibonacciWithRecursion(1));
            Assert.AreEqual(1, Fibonacci.FibonacciWithRecursion(2));
            Assert.AreEqual(2, Fibonacci.FibonacciWithRecursion(3));

            //Cách viết 2:
            Assert.That(Fibonacci.FibonacciWithRecursion(4), Is.EqualTo(3));
            Assert.That(Fibonacci.FibonacciWithRecursion(5), Is.EqualTo(5));
            Assert.That(Fibonacci.FibonacciWithRecursion(20), Is.EqualTo(6765));
            Assert.That(Fibonacci.FibonacciWithRecursion(40), Is.EqualTo(102334155));
        }

        [Test]
        public void testFactorialGivenWrongArguementThrowException()
        {
            Assert.Throws<ArgumentException>(() => { Fibonacci.FibonacciWithRecursion(-1); });
            Assert.Throws<ArgumentException>(() => { Fibonacci.FibonacciWithRecursion(93); });
        }
    }
}