using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProjectForECS
{
    [TestClass]
    public class UnitTest1
    {
       [Test]
        public void TestECS()
        {
            var abe = new FakeTemp();
            var abe2 = new FakeHeater();
            var ECs = new FakeECS(7, abe, abe2);
            ECs.SetThreshold(10);
            NUnit.Framework.Assert.AreEqual(10, ECs.GetThreshold());
        }

        [Test]
        public void QucikMath()
        {
            NUnit.Framework.Assert.AreEqual(10,10);
        }

      
    }
}
