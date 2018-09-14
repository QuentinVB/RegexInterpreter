using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExInterpreter;

namespace TestInterpreter
{
    [TestClass]
    public class ParserTest
    {
        [DataTestMethod]
        [DataRow("ab|c", "(| (+ a b) c)")]//match tree
        [DataRow("ab|c*", "(| (+ a b) (* c))")]//match tree
        [DataRow("ab|(xc)*", "(| (+ a b) (* (+ x c))")]//match tree
        [DataRow("(ab|xc)*", "(* (|(+ a b) ((+ x c)))")]//match tree
        public void tree_parser_test(string regex, string expected)
        {
            //Arrange
            LispParser p = new LispParser(regex);
            //Act
            Node ast = p.Parse();
            //Assert
            Assert.AreEqual(ast.ToString(), expected);
        }
    }
}
