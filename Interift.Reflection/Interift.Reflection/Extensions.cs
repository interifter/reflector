using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interift.Reflection {
    public static class Extensions {

        public static FieldInfo GetField(this object obj, string field, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return Reflector.GetField(obj, field, flags);
        }

        public static PropertyInfo GetProperty(this object obj, string property, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return Reflector.GetProperty(obj, property, flags);
        }
    }
}
