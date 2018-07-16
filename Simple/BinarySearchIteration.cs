using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple {
    public class BinarySearchIteration {
        public int Find(int findValue, int[] sortedArray) {
            if (sortedArray == null || sortedArray.Length == 0 || findValue < sortedArray[0] || findValue > sortedArray[sortedArray.Length - 1]) {
                return -1;
            }
            if (sortedArray[0] == findValue) {
                return 0;
            }
            int startIndex = 0;
            int endIndex = sortedArray.Length - 1;
            while (startIndex<endIndex) {
                int middleIndex = (startIndex + endIndex) / 2;
                if (findValue < sortedArray[middleIndex]) {
                    endIndex = middleIndex - 1;
                } else if (findValue > sortedArray[middleIndex]) {
                    startIndex = middleIndex + 1;
                } else {
                    return middleIndex;
                }
            }

            return -1;
        }
    }
}
