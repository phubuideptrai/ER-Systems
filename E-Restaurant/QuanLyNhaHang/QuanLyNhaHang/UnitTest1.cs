using NUnit.Framework;
using System;

namespace QuanLyNhaHang
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

        [Test]
        public void MD5HashTest_5()
        {
            string str = null;
            Assert.Throws(typeof(ArgumentNullException), () => _model.MD5Hash(str));
        }

        [Test]
        public void testEmail_1()
        {
            string str = "ma@hostname.com";
            Assert.AreEqual(true, _model.IsValidEmail(str));
        }

        [Test]
        public void testEmail_2()
        {
            string str = "ma-a@hostname.com.edu";
            Assert.AreEqual(true, _model.IsValidEmail(str));
        }

        [Test]
        public void testEmail_3()
        {
            string str = "19522018@gm.uit.edu.vn";
            Assert.AreEqual(true, _model.IsValidEmail(str));
        }

        [Test]
        public void testEmail_4()
        {
            string str = "ma@j@jf.com";
            Assert.AreEqual(false, _model.IsValidEmail(str));
        }

        [Test]
        public void testEmail_5()
        {
            string str = null;
            Assert.Throws(typeof(ArgumentNullException), () => _model.IsValidEmail(str));
        }

        [Test]
        public void testPhoneNumber_1()
        {
            string str = "0932112169";
            Assert.AreEqual(true, _model.IsValidPhoneNumber(str));
        }

        [Test]
        public void testPhoneNumber_2()
        {
            string str = "0912345678";
            Assert.AreEqual(true, _model.IsValidPhoneNumber(str));
        }

        [Test]
        public void testPhoneNumber_3()
        {
            string str = "9932106169";
            Assert.AreEqual(false, _model.IsValidPhoneNumber(str));
        }

        [Test]
        public void testPhoneNumber_4()
        {
            string str = "093210616912341";
            Assert.AreEqual(false, _model.IsValidPhoneNumber(str));
        }

        [Test]
        public void testPhoneNumber_5()
        {
            string str = null;
            Assert.Throws(typeof(ArgumentNullException), () => _model.IsValidPhoneNumber(str));
        }
    }
}