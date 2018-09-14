using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExInterpreter;

namespace TestRegex
{
    [TestClass]
    public class BasicTests
    {
        /*
        [DataTestMethod]
        [DataRow("", "", true)]
        [DataRow("a", null, false)]
        [DataRow(null, "a", false)]
        [DataRow(null, null, false)]
        public void safety_test(string regex, string input, bool expected)
        {
            //Arrange
            Analyzer tokenizer = new Analyzer();
            //Act
            bool result = Analyzer.Parse(regex,input);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow("", "", true)]
        [DataRow("", "a", false)] //matched : ""
        [DataRow("a", "a", true)] //matched : "a"
        [DataRow("a", "b", false)] //matched : "a"
        public void simple_char_test(string regex, string input, bool expected)
        {
            //Arrange
            Analyzer tokenizer = new Analyzer();
            //Act
            bool result = Analyzer.Parse(regex);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow("aa", "aa", true)]//matched "aa"
        [DataRow("aa", "a", false)] //matched : "aa"
        [DataRow("aa", "ab", true)] //matched : "aa"
        [DataRow("aa", "abc", false)] //matched : "aa"
        [DataRow("aa", "aab", false)] //matched : "aa"
        [DataRow("aa", "baa", false)] //matched : "aa"
        public void simple_string_test(string regex, string input, bool expected)
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
