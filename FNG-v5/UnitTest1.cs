using NUnit.Framework;

namespace FNG_v5
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(44, 701408733)]
        [TestCase(46, 1836311903)]

        [Timeout(200)]

        public void validIndex(int index, int expected)
        {
            var fibonnaciInstance = new FibonacciNumberGeneratorClass();

            Assert.AreEqual(expected, fibonnaciInstance.getFibonnaci(index));

        }

        [TestCase(-1, -321)]
        [Timeout(200)]

        public void inValidIndex(int index, int expected)
        {
            var fibonnaciInstance = new FibonacciNumberGeneratorClass();

            Assert.AreEqual(expected, fibonnaciInstance.getFibonnaci(index));

        }
    }
}
