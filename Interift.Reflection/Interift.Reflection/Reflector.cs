using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interift.Reflection
{
    public class Reflector {

        public const BindingFlags DEFAULT_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        public const BindingFlags STATIC_FLAGS = DEFAULT_FLAGS | BindingFlags.Static;
        public const BindingFlags FLEX_FLAGS = DEFAULT_FLAGS | BindingFlags.IgnoreCase;


        /// <summary>
        /// Returns a field in the given object.
        /// </summary>
        /// <param name="obj">The object to get the field from</param>
        /// <param name="fieldName">The name of the field in the object</param>
        /// <param name="flags">The binding flags to apply</param>
        /// <returns>A FieldInfo object.</returns>
         public static FieldInfo GetField(object obj, string fieldName, BindingFlags flags = DEFAULT_FLAGS) {
            return GetField(obj.GetType(), fieldName, flags);
        }


        /// <summary>
        /// Returns a field in the given object type. 
        /// </summary>
        /// <param name="obj">The object to get the field from</param>
        /// <param name="fieldName">The name of the field in the object</param>
        /// <param name="flags">The binding flags to apply</param>
        /// <returns>A FieldInfo object.</returns>
        public static FieldInfo GetField(Type t, string fieldName, BindingFlags flags = DEFAULT_FLAGS) {
            return t.GetField(fieldName, flags);
        }


        /// <summary>
        /// Returns the value of the specified field in the object instance
        /// </summary>
        /// <param name="obj">The object to get the field value from</param>
        /// <param name="fieldName">The name of the field in the object</param>
        /// <param name="flags">The binding flags to apply</param>
        /// <returns>The value of the given field from the object instance.</returns>
        public static object GetFieldValue(object obj, string fieldName, BindingFlags flags = DEFAULT_FLAGS) {
            return GetField(obj, fieldName, flags).GetValue(obj);
        }


        /// <summary>
        /// Returns the value of the specified field in the object instance
        /// </summary>
        /// <typeparam name="T">The expected type of the field value</typeparam>
        /// <param name="obj">The object to get the field value from</param>
        /// <param name="fieldName">The name of the field in the object</param>
        /// <param name="flags">The binding flags to apply</param>
        /// <returns>The value of the given field from the object instance.</returns>
        public static T GetFieldValue<T>(object obj, string fieldName, BindingFlags flags = DEFAULT_FLAGS) {
            return (T)GetFieldValue(obj, fieldName, flags);
        }


        /// <summary>
        /// Returns a property in the given object. 
        /// </summary>
        /// <param name="obj">The object to get the property from</param>
        /// <param name="propertyName">The name of the property in the object</param>
        /// <param name="flags">The binding flags to apply</param>
        /// <returns>A PropertyInfo object.</returns>
        public static PropertyInfo GetProperty(object obj, string propertyName, BindingFlags flags = DEFAULT_FLAGS) {
            return GetProperty(obj.GetType(), propertyName, flags);
        }


        /// <summary>
        /// Returns a property in the given object type. 
        /// </summary>
        /// <param name="obj">The object to get the property from</param>
        /// <param name="propertyName">The name of the property in the object</param>
        /// <param name="flags">The binding flags to apply</param>
        /// <returns>A PropertyInfo object.</returns>
        public static PropertyInfo GetProperty(Type t, string propertyName, BindingFlags flags = DEFAULT_FLAGS) {
            return t.GetProperty(propertyName, flags);
        }

    }
}
