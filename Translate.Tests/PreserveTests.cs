using System;
using NUnit.Framework;

namespace Translate.Tests
{
    [TestFixture]
    public class PreserveTests
    {
        #region IsPreserve
        [Test]
        public void ShouldPreserveNull()
        {
            var sut = new Preserve();
            string testString = null;
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void ShouldPreserveEmpty()
        {
            var sut = new Preserve();
            string testString = String.Empty;
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void ShouldPreserveSpaces()
        {
            var sut = new Preserve();
            string testString = "  ";
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void ShouldPreserveComma()
        {
            var sut = new Preserve();
            string testString = ",";
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void ShouldPreserveExclaimation()
        {
            var sut = new Preserve();
            string testString = "!";
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void ShouldPreserveQuestion()
        {
            var sut = new Preserve();
            string testString = "?";
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void ShouldNotPreserveQuestion()
        {
            var sut = new Preserve();
            string testString = "??a";
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, false);
        }

        [Test]
        public void ShouldPreserveVariousGrammar()
        {
            var sut = new Preserve();
            string testString = "?!,";
            var result = sut.IsPreserved(testString);
            Assert.AreEqual(result, true);
        }
        #endregion

        #region PreserveGrammar

        [Test]
        public void ShouldSplitGrammarInMiddle()
        {
            var sut = new Preserve();
            var input = "test!success";
            var result = sut.PreserveGrammar(input);
            var assert = new string[] { "test", "!", "success"};
            Assert.AreEqual(result, assert);
        }

        [Test]
        public void ShouldSplitGrammarInFront()
        {
            var sut = new Preserve();
            var input = "!testsuccess";
            var result = sut.PreserveGrammar(input);
            var assert = new string[] {  "!", "testsuccess" };
            Assert.AreEqual(result, assert);
        }

        [Test]
        public void ShouldSplitGrammarInBack()
        {
            var sut = new Preserve();
            var input = "testsuccess!";
            var result = sut.PreserveGrammar(input);
            var assert = new string[] { "testsuccess", "!" };
            Assert.AreEqual(result, assert);
        }

        [Test]
        public void ShouldNotSplitGrammar()
        {
            var sut = new Preserve();
            var input = "testsuccess";
            var result = sut.PreserveGrammar(input);
            var assert = new string[] { "testsuccess"};
            Assert.AreEqual(result, assert);
        }

        #endregion
    }
}
