using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            var window = new MainWindow();
            Assert.IsFalse(window.Calculate("", "", ""));

            Assert.IsFalse(window.Calculate("12", "", ""));
            Assert.IsFalse(window.Calculate("", "12", ""));
            Assert.IsFalse(window.Calculate("", "", "12"));

            Assert.IsFalse(window.Calculate("3", "12", ""));
            Assert.IsFalse(window.Calculate("", "3", "12"));
            Assert.IsFalse(window.Calculate("1", "", "5"));

            Assert.IsFalse(window.Calculate("40", "12", "12"));
            Assert.IsFalse(window.Calculate("12", "12", "40"));
            Assert.IsFalse(window.Calculate("8", "40", "8"));

            Assert.IsFalse(window.Calculate("-2", "2", "2"));
            Assert.IsFalse(window.Calculate("3", "-4", "2"));
            Assert.IsFalse(window.Calculate("4", "1", "-5"));

            Assert.IsFalse(window.Calculate("asdf", "jyt", "rtb"));
            Assert.IsFalse(window.Calculate("!", "@", "#"));
            Assert.IsFalse(window.Calculate("2,3", "4.3", "3,3"));

            Assert.IsTrue(window.Calculate("18", "32", "5"));
            Assert.IsTrue(window.Calculate("12", "12", "12"));
            Assert.IsTrue(window.Calculate("0", "0", "1"));

        }
    }
}
