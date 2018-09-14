using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExInterpreter;

namespace TestRegex
{
    [TestClass]
    public class OrTests
    {
        /*
        [DataTestMethod]
        [DataRow("a|b", "a", true)] //match "a" or "b"
        [DataRow("a|b", "b", true)] //match "a" or "b"
        [DataRow("a|b", "c", false)] //match "a" or "b"
        [DataRow("a|b", "ac", false)] //match "a" or "b"
        [DataRow("a|b", "ab", false)] //match "a" or "b"
        public void simple_char_or_test(string regex, string input, bool expected)
        {
            //Arrange
            Tokenizer tokenizer = new Tokenizer();
            //Act
            bool result = Tokenizer.Tokenizer(regex);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow("a|b|c", "a", true)] //match "a" or "b" or "c"
        [DataRow("a|b|c", "b", true)] //match "a" or "b" or "c"
        [DataRow("a|b|c", "c", true)] //match "a" or "b" or "c"
        [DataRow("a|b|c", "ca", false)] //match "a" or "b" or "c"
        [DataRow("a|b|c", "bc", false)] //match "a" or "b" or "c"
        [DataRow("a|b|c", "d", false)] //match "a" or "b" or "c"
        public void simple_char_multiple_or_test(string regex, string input, bool expected)
        {
            //Arrange
            Tokenizer tokenizer = new Tokenizer();
            //Act
            bool result = Tokenizer.Tokenizer(regex);
            //Assert
            Assert.AreEqual(expected, result);
        }
        */
    }
}
