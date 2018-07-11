using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple;
using NUnit.Framework;

namespace TestSimple
{
    [TestFixture]
    public class TestGoodByer
    {
        [Test()]
        public void TestConstructorWithParams() {
            Assert.Throws<Exception>( delegate(){ GoodByer goodByer = new GoodByer(""); });
        }
    }
}
