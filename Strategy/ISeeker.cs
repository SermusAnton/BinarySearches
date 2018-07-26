using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    public interface ISeeker:IComparable {
        void SetFindValue(object findValue);
        void SetSortedObj(object sortedObj);
        int GetStart();
        int GetEnd();
        //int GetComparable(object middleObj);
    }
}
