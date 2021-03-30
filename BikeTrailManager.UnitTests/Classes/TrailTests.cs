using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeTrailManager.Classes;

namespace BikeTrailManager.UnitTests.Classes
{
    [TestClass]
    public class TrailTests
    {
        [TestMethod]
        public void DaysPast2020_ValuesAreDefault_ExpectedBehaviour()
        {
            //arange
            var obj = new Trail();

            //act
            var result = obj.DaysPast2020();

            //assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DaysPast2020_LeapYear_ExpectedBehaviour()
        {
            //arrange
            var obj = new Trail();
            obj.year = 2020;
            obj.month = 3;
            obj.day = 24;

            //act
            var result = obj.DaysPast2020();

            //assert
            Assert.AreEqual(result, 84);
        }

        [TestMethod]
        public void DaysPast2020_RegularYear_ExpectedBehaviour()
        {
            //arrange
            var obj = new Trail();
            obj.year = 2021;
            obj.month = 3;
            obj.day = 24;

            //act
            var result = obj.DaysPast2020();

            //assert
            Assert.AreEqual(result, 366 + 83);
        }

        [TestMethod]
        public void DaysPast2020_RegularYear1stMarch_ExpectedBehaviour()
        {
            //arrange
            var obj = new Trail();
            obj.year = 2020;
            obj.month = 3;
            obj.day = 1;

            //act
            var result = obj.DaysPast2020();

            //assert
            Assert.AreEqual(result, 61);
        }

        [TestMethod]
        public void TimeInMinutes_ValuesAreDefault_ExpectedBehaviour()
        {
            var obj = new Trail();

            var result = obj.TimeInMinutes();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TimeInMinutes_ValuesAreZero_ExpectedBehaviour()
        {
            var obj = new Trail();

            var result = obj.TimeInMinutes();

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TimeInMinutes_SomeValues_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.hours = 6;
            obj.minutes = 61;

            var result = obj.TimeInMinutes();

            Assert.AreEqual(result, 421);
        }

        [TestMethod]
        public void TimeInMinutes_SomeValues2_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.hours = 6;
            obj.minutes = 25;

            var result = obj.TimeInMinutes();

            Assert.AreEqual(result, 385);
        }

        [TestMethod]
        public void TrailAvgSpeed_DefaultValues_ExpectedBehaviour()
        {
            var obj = new Trail();

            var result = obj.TrailAvgSpeed();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TrailAvgSpeed_SomeValues_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.distance = 100;
            obj.hours = 10;
            obj.minutes = 0;


            var result = obj.TrailAvgSpeed();

            Assert.AreEqual(result, 10.00);
        }

        [TestMethod]
        public void TrailAvgSpeed_SomeValues2_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.distance = 100;
            obj.hours = 1;
            obj.minutes = 540;


            var result = obj.TrailAvgSpeed();

            Assert.AreEqual(result, 10.00);
        }
    }
}
