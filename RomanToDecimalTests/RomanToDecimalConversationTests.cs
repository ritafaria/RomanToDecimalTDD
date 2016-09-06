using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToDecimalConversion;

namespace RomanToDecimalTests
{
    [TestClass]
    public class RomanToDecimalConversationTests
    {
        [TestMethod]
        public void VerifyDecimalValueForSingleRomanSymbol()
        {
            string romanStr = "V";

            int val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(5, val);

            romanStr = "C";
            val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(100, val);
        }

        [TestMethod]
        public void VerifyDecimalValueForRepeatingRomanSymbol()
        {
            string romanStr = "II";

            int val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(2, val);

            romanStr = "XXX";
            val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(30, val);

            romanStr = "CC";
            val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(200, val);
        }

        [TestMethod]
        public void VerifyDecimalValueForRomansubtractivenotation()
        {
            string romanStr = "IV";

            int val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(4, val);

            romanStr = "CD";
            val = RomanToDecimalConverter.RomanToDecimal(romanStr);
            Assert.AreEqual(400, val);
        }
    }
}
