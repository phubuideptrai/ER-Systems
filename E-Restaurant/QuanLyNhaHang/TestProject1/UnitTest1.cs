using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {
        private Base _model;

        [SetUp]
        public void SetUp()
        {
            _model = new Base();
        }

        [Test]
        public void ConvertToNumbeTest_1()
        {
            string str = "100";
            Assert.AreEqual(100, _model.ConvertToNumber(str));
        }

        [Test]
        public void ConvertToNumbeTest_2()
        {
            string str = "2,001";
            Assert.AreEqual(2001, _model.ConvertToNumber(str));
        }

        [Test]
        public void ConvertToNumbeTest_3()
        {
            string str = "7,600,000";
            Assert.AreEqual(7600000, _model.ConvertToNumber(str));
        }

        [Test]
        public void ConvertToNumbeTest_4()
        {
            string str = "";
            Assert.Throws<FormatException>(() => _model.ConvertToNumber(str));
        }

        [Test]
        public void ConvertToNumbeTest_5()
        {
            string str = null;
            Assert.Throws<NullReferenceException>(() => _model.ConvertToNumber(str));
        }

        [Test]
        public void MD5HashTest_1()
        {
            string str = "";
            Assert.AreEqual("D41D8CD98F00B204E9800998ECF8427E", _model.MD5Hash(str));
        }

        [Test]
        public void MD5HashTest_2()
        {
            string str = "@";
            Assert.AreEqual("518ED29525738CEBDAC49C49E60EA9D3", _model.MD5Hash(str));
        }

        [Test]
        public void MD5HashTest_3()
        {
            string str = "3";
            Assert.AreEqual("ECCBC87E4B5CE2FE28308FD9F2A7BAF3", _model.MD5Hash(str));
        }

        [Test]
        public void MD5HashTest_4()
        {
            string str = "admin 1$";
            Assert.AreEqual("E8BABFBB9799BADD295B08666B32A4D3", _model.MD5Hash(str));
        }
    }
}