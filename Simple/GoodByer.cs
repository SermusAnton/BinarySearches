using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple {
    public class GoodByer {
        private string who;
        public string Message {
            get { return "Привет "+who; }
            set {
                if (value == "") {
                    throw new Exception("No person to say goodbay!!!");
                }
                who = value;
            }
        }
        public GoodByer() {
            who = "Anonim";
        }
        public GoodByer(string who) {
            if (who == "") {
                throw new Exception("No person to say goodbay!!!");
            }
            this.who = who;
        }
    }
}
