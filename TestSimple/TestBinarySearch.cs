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
    public class TestBinarySearch
    {
        #region Группа 1
        [Test()]
        public void LengthNullElement() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(3, new int[]{ }));
           
        }
        [Test()]
        public void LengthOneElement() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(3, new int[] { 1 }));
        }
        [Test()]
        public void FindInOneElement() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1 }));
        }
        #endregion
        #region Группа 2
        [Test()]
        public void FindIfFistIndex() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1,3,5 }));
        }
        [Test()]
        public void FindIndex() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5 }));
        }
        #endregion
    }
}
