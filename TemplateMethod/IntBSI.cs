using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    public class IntBSI : Iteration {

        private int[] sortedArray = null;
        private int findValue = 0;

        protected override bool IsFindValueGreater(int index) {
            return findValue > sortedArray[index];
        }

        protected override bool IsFindValue(int index) {
            return findValue == sortedArray[index];
        }

        protected override bool IsCanStart() {
        //    if (end<start) return false;
            return IsFindValueGreater(start) && !IsFindValueGreater(end);
        }

        public int Find(int findValue, int[] sortedArray) {
            this.sortedArray = sortedArray;
            this.findValue = findValue;
            start = 0;
            end = sortedArray.Length -1 ;
            return DoFind();
        }
    }
}
