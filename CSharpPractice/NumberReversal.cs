using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpPractice
{
    /// <summary>
    /// ReverseNumber takes a natural number and gives back a new number created
    /// from the digits of the input in reverse order.
    /// </summary>
    [TestFixture]
    [Medium]
    public class NumberReserval
    {
        private long ReverseNumber(long n)
        {
            throw new NotImplementedException();
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void ReverseNumber(long input, long expectedOutput)
        {
            Assert.That(ReverseNumber(input), Is.EqualTo(expectedOutput));
        }

        public static IEnumerable<TestCaseData> TestCases
            => new[]
            {
                new TestCaseData(1, 1),
                new TestCaseData(10000, 1),
                new TestCaseData(12345, 54321),
                new TestCaseData(98765, 56789),
                new TestCaseData(12121, 12121),
            };
    }
}