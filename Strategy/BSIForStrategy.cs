using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    public class BSIForStrategy {

        private ISeeker itsSortedObj = null;
        private int start=0;
        private int end=0;
        private int operations = 0;
        private int result = -1;
        

        public BSIForStrategy(ISeeker itsISeeker) {
            this.itsSortedObj = itsISeeker;                
        }

        public int Find(object findValue, object sortedObj) {
            itsSortedObj.SetSortedObj(sortedObj);
            itsSortedObj.SetFindValue(findValue);
            start = itsSortedObj.GetStart();
            end = itsSortedObj.GetEnd();
            operations = 0;
           
            if (!IsCanStart()) return result;

            while (start < end) {
                ++operations;
                int middle = (start + end) / 2;
                if (itsSortedObj.CompareTo(middle) < 0) {
                    end = middle - 1;
                } else if (itsSortedObj.CompareTo(middle) > 0) {
                    start = middle + 1;
                } else {
                    result = middle;
                    return result;
                }            
            }
            return -1;
        }

        private bool IsCanStart() {
            if (end==-1) {
                result = -1;
                return false;
            }
            if (itsSortedObj.CompareTo(start) < 0) {
                result = -1;
                return false;
            }
            if (itsSortedObj.CompareTo(start) == 0) {
                result = start;
                return false;
            }
            if (itsSortedObj.CompareTo(end) > 0) {
                result = -1;
                return false;
            }
            if (itsSortedObj.CompareTo(end) == 0) {
                result = end;
                return false;
            }
            return true;
        }

    }
}
