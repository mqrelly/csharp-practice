using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharpPractice
{
    /// <summary>
    /// Implement the IsPalindrom method so that it gives back true when
    /// the passed in string is the same as reversed and false otherwise.
    /// </summary>
    [TestFixture]
    [Easy]
    public class Palindroms
    {
        private bool IsPalindrom(string s)
        {
            throw new NotImplementedException();
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void IsPalindromTests(string input, bool expectedResult)
        {
            var isPalindrom = IsPalindrom(input);

            Assert.That(isPalindrom, Is.EqualTo(expectedResult));
        }

        public static IEnumerable<TestCaseData> TestCases
            => new[]
            {
                new TestCaseData("", true),
                new TestCaseData("a", true),
                new TestCaseData("aa", true),
                new TestCaseData("aaa", true),
                new TestCaseData("aba", true),
                new TestCaseData("abc", false),
                new TestCaseData("asdffdsa", true),
                new TestCaseData("asdfasdf", false),
                new TestCaseData("indulagörögaludni", true),
                new TestCaseData("indulagörögaludní", false),
                new TestCaseData("indulagörögaludnI", false),
                new TestCaseData("rétipipitér", true),
                new TestCaseData("with spaces secaps htiw", true)
            };
    }
}