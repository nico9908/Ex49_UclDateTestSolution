using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;

namespace DateUnitTestProject
{
    [TestClass]
    public class UnitTestDate
    {
        UclDate ucl = new UclDate(2019, 12, 29);
        [TestMethod]
        public void TestMethod_DateConstructor()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");
        }
        [TestMethod]
        public void GetYear()   
        {
            Assert.AreEqual(ucl.GetYear(), 2019);
        }
        [TestMethod]
        public void GetMonth()
        {
            Assert.AreEqual(ucl.GetMonth(), 12);
        }
        [TestMethod]
        public void GetDay()
        {
            Assert.AreEqual(ucl.GetDay(), 29);
        }
        [TestMethod]
        public void SetYear()
        {
            Assert.AreEqual(ucl.SetYear());
        }
        [TestMethod]
        public void SetMonth()
        {

        }
        [TestMethod]
        public void SetDay()
        {

        }
        [TestMethod]
        public void GetDateStringYMD()
        {
            Assert.AreEqual(ucl.GetDatoStringYMD(), "2019-12-29");
        }
        [TestMethod]
        public void GetDatoStringDMY()
        {
            Assert.AreEqual(ucl.GetDatoStringDMY(), "29/12/2019");
        }
        [TestMethod]
        public void GetQuarter()
        {

        }
        [TestMethod]
        public void GetMonthTxt()
        {
            Assert.AreEqual(ucl.GetMonthTxt(), "December");
        }
        [TestMethod]
        public void GetQuarterTxt()
        {

        }
    }
}
