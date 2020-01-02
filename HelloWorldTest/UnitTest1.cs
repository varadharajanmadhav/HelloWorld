using System;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            if("Hello World" != Program.GetMessage())
            {
                throw new Exception("Message is not equal");
            }
        }
    }
}
