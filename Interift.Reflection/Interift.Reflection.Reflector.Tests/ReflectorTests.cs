using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interift.Reflection.Tests.Resources;


namespace Interift.Reflection.Tests {
    [TestClass]
    public class ReflectorTests {
        [TestMethod]
        public void GetFieldTest1() {
            var blandObj = new BlandObject();
            var blandField = blandObj.GetField("_privateStringField");
            Assert.AreEqual(blandObj.PublicStringField, blandField.GetValue(blandObj));
            blandField.SetValue(blandObj, "My new value");

            Assert.AreEqual("My new value", blandObj.PublicStringField);
        }

        [TestMethod]
        public void GetFieldTest2() {
            var field = Reflector.GetField(typeof(BlandObject), "_privateStringField");
            var obj1 = new BlandObject();
            var obj2 = new BlandObject();
            Assert.AreEqual(obj1.PublicStringField, obj2.PublicStringField);
            field.SetValue(obj1, "val1");
            field.SetValue(obj2, "val2");

            Assert.AreEqual("val1", obj1.PublicStringField);
            Assert.AreEqual("val2", obj2.PublicStringField);
        }

        [TestMethod]
        public void GetFieldValueTest1() {
            BlandObject obj = new BlandObject();
            var myField = obj.GetFieldValue<string>("_privateStringField");
            Assert.AreEqual(obj.PublicStringField, myField);
        }

        [TestMethod]
        public void GetPropertyTest1() {
            BlandObject obj = new BlandObject();
            var myProp = obj.GetProperty("PublicStringField");
            Assert.AreEqual(obj.PublicStringField, myProp.GetValue(obj));
        }

        [TestMethod]
        public void GetPropertyValueTest1() {
            BlandObject obj = new BlandObject();
            var myPropVal = obj.GetPropertyValue<string>("PublicStringField");
            Assert.AreEqual(obj.PublicStringField, myPropVal);
        }


        [TestMethod]
        public void ProcessDynamicInputTest1() {
            var inputs = new [] { "Blackberry", "iPhone", "Android", "Nokia" };

            foreach(var input in inputs) {
                var myObj = Reflector.CreateInstance<Phone>(typeof(Phone), input);
                Assert.AreEqual(myObj.Name, input);
                Assert.IsTrue(myObj.GetType().Name.Equals(input, StringComparison.OrdinalIgnoreCase));
            }
        }
    }


}
