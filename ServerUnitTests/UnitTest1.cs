using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Services;
using Shouldly;

namespace ServerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethodException()
        {
            var service = new FileSync();

            service.GetFile("");
        }
        
        [TestMethod]
        public void TestMethodSuccess()
        {
            
        }
    }
}
