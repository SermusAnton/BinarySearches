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
        /// <summary>
        /// Тест пустого конструктора
        /// </summary>
        [Test()]
        public void TestConstructorWithParams() {
            Assert.Throws<Exception>( delegate(){ GoodByer goodByer = new GoodByer(""); });
        }
        /// <summary>
        /// Тест конструктора с параметром
        /// </summary>
        [Test()]
        public void TestConstructor() {
            GoodByer goodByer = new GoodByer("Jhon");
            Assert.AreEqual("Привет Jhon",goodByer.Message);
        }
        /// <summary>
        /// Тест свойства Message String.Empty 
        /// </summary>
        [Test()]
        public void TestSetWhoEmpty() {
            GoodByer goodByer = new GoodByer();
            Assert.Throws<Exception>(delegate () { goodByer.Message=""; });
        }
        /// <summary>
        /// Тест свойства Message задаем значение 
        /// </summary>
        [Test()]
        public void TestSetWhoNotEmpty() {
            GoodByer goodByer = new GoodByer();
            goodByer.Message = "Jhon";
            Assert.AreEqual("Привет Jhon",goodByer.Message);
        }
    }
}
