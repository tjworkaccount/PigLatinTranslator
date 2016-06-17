using System;
using NUnit.Framework;

namespace Translate.Tests
{
    [TestFixture]
    public class TranslateTests
    {
        [Test]
        public void ShouldTranslateWithSingleWord()
        {
            var sut = new Translator("testing");
            var result = sut.Translate();
            Assert.AreEqual("estingtay", result);
        }

        [Test]
        public void ShouldTranslateWithMultipleWords()
        {
            var sut = new Translator("No littering");
            var result = sut.Translate();
            Assert.AreEqual("Onay itteringlay", result);
        }

        [Test]
        public void ShouldTranslateWithMultipleWordsSingleGrammar()
        {
            var sut = new Translator("No shirts, no shoes, no service");
            var result = sut.Translate();
            Assert.AreEqual("Onay irtsshay, onay oesshay, onay ervicesay", result);
        }

        [Test]
        public void ShouldTranslateWithMultipleWordsAndNumbers()
        {
            var sut = new Translator("No persons under 14 admitted");
            var result = sut.Translate();
            Assert.AreEqual("Onay ersonspay underay 14 admitteday", result);
        }

        [Test]
        public void ShouldTranslateWithMultipleWordsAndGrammars()
        {
            var sut = new Translator("Hey buddy, get away from my car!");
            var result = sut.Translate();
            Assert.AreEqual("Eyhay uddybay, etgay awayay omfray ymay arcay!", result);
        }

    }
}
