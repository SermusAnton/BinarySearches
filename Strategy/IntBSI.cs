using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Strategy {
    public class IntBSI : ISeeker {

        private int findValue;
        private int[] sortedArray = null;

        public void SetFindValue(object findValue) {
            this.findValue = (int)findValue;
        }

        public void SetSortedObj(object sortedObj) {
            this.sortedArray = (int[]) sortedObj;
        }

        public int GetStart() {
            return 0;
        }

        public int GetEnd() {
            return sortedArray.Length-1;
        }

        public int CompareTo(object obj) {
            int comparator = (int)obj;
            if (findValue < sortedArray[comparator]) return -1;
            if (findValue == sortedArray[comparator]) return 0;
            if (findValue > sortedArray[comparator]) return 1;
            return -1;
        }
    }
}