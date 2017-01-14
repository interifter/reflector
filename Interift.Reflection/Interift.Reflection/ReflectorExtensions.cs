using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interift.Reflection {
    public static class ReflectorExtensions {

        public static FieldInfo GetField(this object obj, string field, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return Reflector.GetField(obj, field, flags);
        }

        public static object GetFieldValue(this object obj, string field, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return Reflector.GetFieldValue(obj, field, flags);
        }

        public static T GetFieldValue<T>(this object obj, string field, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return (T)GetFieldValue(obj, field, flags);
        }

        public static PropertyInfo GetProperty(this object obj, string property, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return Reflector.GetProperty(obj, property, flags);
        }

        public static object GetPropertyValue(this object obj, string property, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return Reflector.GetPropertyValue(obj, property, flags);
        }

        public static T GetPropertyValue<T>(this object obj, string property, BindingFlags flags = Reflector.DEFAULT_FLAGS) {
            return (T)GetPropertyValue(obj, property, flags);
        }

        
    }
}
