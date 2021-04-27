using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("stasia-20", "54321", "Ilya@gmail.com", 79992647826);

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("stasia-20", people.Login);
            
        }
        [TestMethod]
        public void GetEmailTest()
        {
            Assert.AreEqual("anasastasiaromanenko040101@gmail.com", people.Email);

        }

        [TestMethod]
        public void GetPhoneTest()
        {
            Assert.AreEqual(79992647826, people.Phone);

        }
        [TestMethod]
        public void GetPassTest()
        {
            Assert.AreEqual("54321", people.Pass);

        }
    }
}
