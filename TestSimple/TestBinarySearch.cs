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
        BinarySearch binarySearch = new BinarySearch();
        #region Группа 1
        [Test()]
        public void LengthNullElement() {
            Assert.AreEqual(-1, binarySearch.Find(3, new int[]{ }));
        }
        [Test()]
        public void LengthOneElement() {
            Assert.AreEqual(-1, binarySearch.Find(3, new int[] { 1 }));
        }
        [Test()]
        public void FindInOneElement() {
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1 }));
        }
        #endregion
        #region Группа 2
        [Test()]
        public void FindIfFistIndex() {
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1,3,5 }));
        }
        [Test()]
        public void FindIndex3() {
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex5() {
            Assert.AreEqual(2, binarySearch.Find(5, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex0() {
            Assert.AreEqual(-1, binarySearch.Find(0, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex2() {
            Assert.AreEqual(-1, binarySearch.Find(2, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex4() {
            Assert.AreEqual(-1, binarySearch.Find(4, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void FindIndex6() {
            Assert.AreEqual(-1, binarySearch.Find(6, new int[] { 1, 3, 5 }));
        }
        #endregion
        #region Группа 3
        [Test()]
        public void FindIndexEvenArray1() {
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1, 3, 5, 7}));
        }
        [Test()]
        public void FindIndexEvenArray3() {
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray5() {
            Assert.AreEqual(2, binarySearch.Find(5, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray7() {
            Assert.AreEqual(3, binarySearch.Find(7, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray0() {
            Assert.AreEqual(-1, binarySearch.Find(0, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray2() {
            Assert.AreEqual(-1, binarySearch.Find(2, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray4() {
            Assert.AreEqual(-1, binarySearch.Find(4, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray6() {
            Assert.AreEqual(-1, binarySearch.Find(6, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void FindIndexEvenArray8() {
            Assert.AreEqual(-1, binarySearch.Find(8, new int[] { 1, 3, 5, 7 }));
        }
        #endregion
    }
}
