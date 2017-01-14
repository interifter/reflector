﻿using System;
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
    }


}