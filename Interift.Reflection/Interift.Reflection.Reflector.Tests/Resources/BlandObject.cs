using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interift.Reflection.Tests.Resources {
    class BlandObject {
        private string _privateStringField;

        public string PublicStringField {
            get {
                return _privateStringField;
            }
            private set {
                _privateStringField = value;
            }
        }

        public BlandObject() {
            PublicStringField = "this is the original value";
        }
    }
}
