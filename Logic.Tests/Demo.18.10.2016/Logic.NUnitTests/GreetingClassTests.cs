using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using static Logic.GreetingClass;

namespace Logic.NUnitTests
{
    [TestFixture]
    public class GreetingClassTests
    {
        //variant 2
        public IEnumerable<TestCaseData> TestData
        {
            get
            {
                yield return new TestCaseData("Vasia").Returns("Hello, Vasia!");
                yield return new TestCaseData("").Returns("Hello, anonim!");
                yield return new TestCaseData(null).Throws(typeof(ArgumentNullException));
            }
        }

        //variant 1
        [TestCase("Vasia", Result = "Hello, Vasia!")]
        [TestCase(null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase("", Result = "Hello, anonim!")]
        public string GreetingMethod_HelloConcatUserName(string userName)
        {
            return GreetingMethod(userName);
        }

        [Test, TestCaseSource(nameof(TestData))]
        public string GreetingMethod_HelloConcatUserNameWithYield(string userName)
        {
            Debug.WriteLine("Hello!");
            return GreetingMethod(userName);
        }
    }
}
