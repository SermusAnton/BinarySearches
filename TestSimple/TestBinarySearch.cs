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
        public void FindIndex3() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex5() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(2, binarySearch.Find(5, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex0() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(0, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex2() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(2, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex4() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(4, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex6() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(6, new int[] { 1, 3, 5 }));
        }
        #endregion
        #region Группа 3
        [Test()]
        public void FindIndexEvenArray1() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1, 3, 5, 7}));
        }
        [Test()]
        public void FindIndexEvenArray3() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray5() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(2, binarySearch.Find(5, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray7() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(3, binarySearch.Find(7, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray0() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(0, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray2() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(2, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray4() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(4, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray6() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(6, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray8() {
            BinarySearch binarySearch = new BinarySearch();
            Assert.AreEqual(-1, binarySearch.Find(8, new int[] { 1, 3, 5, 7 }));
        }
        #endregion
    }
}
