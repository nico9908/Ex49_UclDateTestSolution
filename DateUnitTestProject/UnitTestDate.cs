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
            Assert.AreEqual(ucl.GetYear(), 2019);
        }
        [TestMethod]
        public void SetMonth()
        {
            Assert.AreEqual(ucl.GetMonth(), 12);
        }
        [TestMethod]
        public void SetDay()
        {
            Assert.AreEqual(ucl.GetDay(), 29);
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
            Assert.AreEqual(ucl.GetQuater(), 4);
        }
        [TestMethod]
        public void GetMonthTxt()
        {
            Assert.AreEqual(ucl.GetMonthTxt(), "December");
        }
        [TestMethod]
        public void GetQuarterTxt()
        {
            Assert.AreEqual(ucl.GetQuaterTxt(), "Oktober kvartal");
        }
        [TestMethod]
        public void MoveToNextDate()
        {
            Assert.AreEqual(ucl.MoveToNextDate(), 1);
        }
        [TestMethod]
        public void MoveToPrevDate()
        {
            Assert.AreEqual(ucl.MoveToPrevDate(), 1);
        }
        [TestMethod]
        public void MoveDays()
        {
            Assert.AreEqual(ucl.MoveDays(), 1);
        }
        [TestMethod]
        public void GetDayNumber()
        {
            Assert.AreEqual(ucl.GetDayNumber(), 333);
        }
        [TestMethod]
        public void SetDayNumber()
        {
            Assert.AreEqual(ucl.GetDayNumber(), 333);
        }
        [TestMethod]
        public void GetAbsDayNumber()
        {
            Assert.AreEqual(ucl.GetAbsDayNumber(), -1);
        }
        [TestMethod]
        public void GetWeekDay()
        {
            Assert.AreEqual(ucl.GetWeekDay(), 5);
        }
        [TestMethod]
        public void GetWeek()
        {
            Assert.AreEqual(ucl.GetWeek(), 47);
        }
    }
}