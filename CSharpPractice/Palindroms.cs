using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpPractice
{
    [TestFixture]
    public class Palindroms
    {
        /// <summary>
        /// Implement the IsPalindrom method so that it gives back true when
        /// the passed in string is the same as reversed and false otherwise.
        /// </summary>
        #region Is palindrom problem

        private bool IsPalindrom(string s)
        {
            throw new NotImplementedException();
        }

        [Easy]
        [Test]
        [TestCaseSource(nameof(PalindromCases))]
        public void IsPalindromTests(string input, bool expectedResult)
        {
            var isPalindrom = IsPalindrom(input);

            Assert.That(isPalindrom, Is.EqualTo(expectedResult));
        }

        public static IEnumerable<TestCaseData> PalindromCases
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

        #endregion


        /// <summary>
        /// Given an input string find (one of) the longest substrings which is
        /// a palindrom. But do not include trivial palindroms like the empty
        /// string, or a one character long string.
        /// If more longest palindroms exist, it doesn't matter which one the
        /// method gives back.
        /// 
        /// You must first implement the IsPalindrom method in the previous
        /// challenge, the tests are depending on it.
        /// </summary>
        #region Longest palindrom problem

        private bool FindLongestNonTrivialPalindrom(string input, out int startsAt, out int length)
        {
            throw new NotImplementedException();
        }

        [Medium]
        [Test]
        [TestCaseSource(nameof(LongestPalindromCases))]
        public void LongestNonTrivialPalindromTests(
            string input,
            bool shouldContainPalindrom,
            int expectedLength)
        {
            int startsAt, length;
            var containsPalindrom = FindLongestNonTrivialPalindrom(input, out startsAt, out length);

            if (shouldContainPalindrom)
            {
                Assert.That(containsPalindrom, Is.True);
                Assert.That(length, Is.EqualTo(expectedLength));

                var candidate = input.Substring(startsAt, length);
                Assert.That(IsPalindrom(candidate), Is.True);
            }
            else
            {
                Assert.That(containsPalindrom, Is.False);
            }
        }

        public static IEnumerable<TestCaseData> LongestPalindromCases
            => new[]
            {
                new TestCaseData("", false, -1),
                new TestCaseData("a", false, -1),
                new TestCaseData("aa", true, 2),
                new TestCaseData("aaa", true, 3),
                new TestCaseData("abb", true, 2),
                new TestCaseData("Xaba", true, 3),
                new TestCaseData("asdffdsA", true, 6),
                new TestCaseData(".aba asdf aBBa", true, 4),
                new TestCaseData(".aba asdf aBa", true, 3),
                new TestCaseData(".aba asdf aBBa.aa", true, 4),
                new TestCaseData("abcdefABFDEF123456", false, -1),
            };

        #endregion
    }
}