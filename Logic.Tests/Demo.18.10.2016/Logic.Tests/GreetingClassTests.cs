using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Logic.GreetingClass;

namespace Logic.Tests
{
    [TestClass]
    public class GreetingClassTests
    {

        [TestMethod]
        public void GreetingMethod_HelloConcatName_ReturnedHelloNameString()
        {
            //Arrange Act Assert (AAA)

            //Arrange
            string userName = "Jeffrey Richter";
            string arrangeString = $"Hello, {userName}!";
            Debug.WriteLine("Bla-bla-bla");

            //Act
            string actString = GreetingMethod(userName);

            //Assert
            Assert.AreEqual(arrangeString, actString);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GreetingMethod_HelloConcatNull_ReturnedException()
        {
            string userName = null;

            string actString = GreetingMethod(userName);
        }

        [TestMethod]
        public void GreetingMethod_HelloConcatEmptyString_ReturnedHelloAnonim()
        {
            string userName = string.Empty;

            string arrangeString = "Hello, anonim!";

            string actString = GreetingMethod(userName);

            Assert.AreEqual(arrangeString, actString);
        }
    }
}