using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple {
    /// <summary>
    /// http://codekata.com/kata/kata02-karate-chop/
    /// </summary>
    public class BinarySearchRecursion {
        public int Find(int findValue, int[] sortedArray) {
            if (sortedArray == null || sortedArray.Length == 0 || findValue < sortedArray[0]|| findValue>sortedArray[sortedArray.Length-1]) { 
                return -1;
            }
            if (sortedArray[0] == findValue) {
                    return 0;
            }
            return Bisect(findValue,0,sortedArray.Length-1,sortedArray);
        }
        public int Bisect(int findValue, int startInd, int endInd, int[] sortedArray) {
            if (startInd > endInd) {
                return -1;
            }
            int middleInd = (startInd + endInd) / 2;
            if (findValue < sortedArray[middleInd]) {
                return Bisect(findValue, startInd, middleInd-1, sortedArray);
            }
            if (findValue > sortedArray[middleInd]) {
                return Bisect(findValue, middleInd+1, endInd, sortedArray);
            }
            if (findValue == sortedArray[middleInd]) {
                return middleInd;
            }
            return -1;
        }
    }
}
