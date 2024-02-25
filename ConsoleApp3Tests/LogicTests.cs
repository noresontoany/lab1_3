using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void answerTest1()
        {
            var message = Logic.answer("процессор", "информация");

            Assert.AreEqual("нет да да да нет нет ", message);
        }

        [TestMethod()]
        public void answerTest2()
        {
            var message = Logic.answer("qweasdewqqwe", "qwe");

            Assert.AreEqual("да да да нет нет нет ", message);
        }
    }
}