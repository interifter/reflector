using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interift.Reflection.Tests.Resources {
    public class IPhone : Phone {
        public IPhone() {
            base.Name = "iPhone";
            base.Company = "Apple";
        }
    }

    public class Android : Phone {
        public Android() {
            base.Name = "Android";
            base.Company = "Google";
        }
    }

    public class Blackberry : Phone {
        public Blackberry() {
            base.Name = "Blackberry";
            base.Company = "Blackberry";
        }
    }

    public class Nokia : Phone {
        public Nokia() {
            base.Name = "Nokia";
            base.Company = "Nokia";
        }
    }
}
