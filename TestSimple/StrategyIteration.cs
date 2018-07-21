using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Strategy;

namespace Test {
    [TestFixture]
    class StrategyIteration {
 
        IntBSI intBSI = null;
        Strategy.Iteration binarySearch = null;
        public StrategyIteration() {
            intBSI = new IntBSI();
            binarySearch = new Strategy.Iteration(intBSI);
        }
           
        // int index = binarySearch.Find (findValue, sortedArray);
        #region Группа 1
        [Test()]
        public void A1LengthNullElement() {
            Assert.AreEqual(-1, binarySearch.Find(3, new int[] { }));
        }
        [Test()]
        public void A2LengthOneElement() {
            Assert.AreEqual(-1, binarySearch.Find(3, new int[] { 1 }));
        }
        [Test()]
        public void A3FindInOneElement() {
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1 }));
        }
        #endregion
        #region Группа 2
        [Test()]
        public void A4FindIfFistIndex() {
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void A5FindIndex3() {
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void A6FindIndex5() {
            Assert.AreEqual(2, binarySearch.Find(5, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void A7FindIndex0() {
            Assert.AreEqual(-1, binarySearch.Find(0, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void A8FindIndex2() {
            Assert.AreEqual(-1, binarySearch.Find(2, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void A9FindIndex4() {
            Assert.AreEqual(-1, binarySearch.Find(4, new int[] { 1, 3, 5 }));
        }
        [Test()]
        public void B1FindIndex6() {
            Assert.AreEqual(-1, binarySearch.Find(6, new int[] { 1, 3, 5 }));
        }
        #endregion
        #region Группа 3
        [Test()]
        public void B2FindIndexEvenArray1() {
            Assert.AreEqual(0, binarySearch.Find(1, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void B3FindIndexEvenArray3() {
            Assert.AreEqual(1, binarySearch.Find(3, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void B4FindIndexEvenArray5() {
            Assert.AreEqual(2, binarySearch.Find(5, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void B5FindIndexEvenArray7() {
            Assert.AreEqual(3, binarySearch.Find(7, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void B7FindIndexEvenArray0() {
            Assert.AreEqual(-1, binarySearch.Find(0, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void B8FindIndexEvenArray2() {
            Assert.AreEqual(-1, binarySearch.Find(2, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void B9FindIndexEvenArray4() {
            Assert.AreEqual(-1, binarySearch.Find(4, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void C1FindIndexEvenArray6() {
            Assert.AreEqual(-1, binarySearch.Find(6, new int[] { 1, 3, 5, 7 }));
        }
        [Test()]
        public void C2FindIndexEvenArray8() {
            Assert.AreEqual(-1, binarySearch.Find(8, new int[] { 1, 3, 5, 7 }));
        }
        #endregion
    }

}