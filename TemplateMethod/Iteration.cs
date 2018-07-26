using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Iteration {
        protected int start=0;
        protected int end=0;
        private int operations=0;
        
        public int Operations { get => operations; private set => operations = value; }
        
        protected int DoFind() {
            if (!IsCanStart()) return -1;
            if (IsFindValue(start)) return start;
            if (IsFindValue(end)) return end;

            while (start < end) {
                ++operations;
                int middle = (start + end) / 2;

                if (IsFindValue(middle)) return middle;

                if (IsFindValueGreater(middle)) {
                    start = middle + 1;
                } else {
                    end = middle - 1;
                }
            }
            return -1;
        }

        private bool IsCanStart() {
            if (end < start) return false;
            if (IsFindValue(start)) return true;
            return IsFindValueGreater(start) && !IsFindValueGreater(end);
        }

        protected abstract bool IsFindValue(int index);
        protected abstract bool IsFindValueGreater(int index);
    }
}
