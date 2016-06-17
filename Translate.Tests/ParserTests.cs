using System;
using NUnit.Framework;

namespace Translate.Tests
{
    [TestFixture]
    public class ParserTests
    {
        #region TranslateWord
        [Test]
        public void ShouldNotSplitVowel()
        {
            var sut = new Parser();
            var input = "brr";
            var result = sut.TranslateWord(input);
            Assert.AreEqual("brryay", result);
        }

        [Test]
        public void ShouldSplitVowel()
        {
            var sut = new Parser();
            var input = "sandwich";
            var result = sut.TranslateWord(input);
            Assert.AreEqual("andwichsay", result);
        }
        #endregion

        #region FormatWord

        [Test]
        public void ShouldFormatCapitalizeFirstLetter()
        {
            var sut = new Parser();
            var input = "Testing";
            var result = sut.FormatWord(input);
            Assert.AreEqual("Estingtay", result);
        }

        [Test]
        public void ShouldNotFormatCapitalizeFirstLetter()
        {
            var sut = new Parser();
            var input = "testing";
            var result = sut.FormatWord(input);
            Assert.AreEqual("estingtay", result);
        }

        #endregion

        #region ParseWord

        [Test]
        public void ShouldParseWordWithoutFormatting()
        {
            var sut = new Parser();
            var input = "testing";
            var result = sut.ParseWord(input);
            Assert.AreEqual("estingtay", result);
        }

        [Test]
        public void ShouldParseWordWithFormattingStart()
        {
            var sut = new Parser();
            var input = "!testing";
            var result = sut.ParseWord(input);
            Assert.AreEqual("!estingtay", result);
        }

        [Test]
        public void ShouldParseWordWithFormattingEnd()
        {
            var sut = new Parser();
            var input = "testing!";
            var result = sut.ParseWord(input);
            Assert.AreEqual("estingtay!", result);
        }

        [Test]
        public void ShouldParseWordWithFormattingMiddle()
        {
            var sut = new Parser();
            var input = "test!success";
            var result = sut.ParseWord(input);
            var assert = "esttay!uccesssay";
            Assert.AreEqual(result, assert);
        }

        #endregion
    }
}
