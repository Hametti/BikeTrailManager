using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeTrailManager.Classes;
using System.Collections.Generic;
using System;

namespace BikeTrailManager.UnitTests
{
    [TestClass]
    public class TrailManagerTests
    {

        [TestMethod]
        public void FindTrailSeason_DefaultData_ExpectedBehaviour()
        {
            var obj = new Trail();

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FindTrailSeason_Case1_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 3;
            obj.day = 20;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Zima");
        }

        [TestMethod]
        public void FindTrailSeason_Case2_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 3;
            obj.day = 21;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Wiosna");
        }

        [TestMethod]
        public void FindTrailSeason_Case3_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 6;
            obj.day = 21;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Wiosna");
        }

        [TestMethod]
        public void FindTrailSeason_Case4_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 6;
            obj.day = 22;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Lato");
        }

        [TestMethod]
        public void FindTrailSeason_Case5_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 9;
            obj.day = 22;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Lato");
        }

        [TestMethod]
        public void FindTrailSeason_Case6_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 9;
            obj.day = 23;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Jesień");
        }

        [TestMethod]
        public void FindTrailSeason_Case8_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 12;
            obj.day = 20;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Jesień");
        }

        [TestMethod]
        public void FindTrailSeason_Case9_ExpectedBehaviour()
        {
            var obj = new Trail();
            obj.month = 12;
            obj.day = 21;

            var result = TrailsManager.FindTrailSeason(obj);

            Assert.AreEqual(result, "Zima");
        }

        [TestMethod]
        public void FindOldestTrailIn_DefaultData_ExpectedBehaviour()
        {
            var obj = new Trail();
            var trailsList = new List<Trail>();
            trailsList.Add(obj);

            var result = TrailsManager.FindOldestTrailIn(trailsList);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FindOldestTrailIn_TestData_ExpectedBehaviour()
        {
            var obj1 = new Trail();
            obj1.day = 3;
            obj1.month = 1;
            obj1.year = 2020;

            var obj2 = new Trail();
            obj2.day = 1;
            obj2.month = 1;
            obj2.year = 2020;

            var obj3 = new Trail();
            obj3.day = 1;
            obj3.month = 2;
            obj3.year = 2021;
            var trailsList = new List<Trail>();
            trailsList.Add(obj1);
            trailsList.Add(obj2);
            trailsList.Add(obj3);

            var result = TrailsManager.FindOldestTrailIn(trailsList).DaysPast2020();

            Assert.AreEqual(result, obj2.DaysPast2020());
        }

        [TestMethod]
        public void FindLastTrailIn_DefaultData_ExpectedBehaviour()
        {
            var obj = new Trail();
            var trailsList = new List<Trail>();
            trailsList.Add(obj);

            var result = TrailsManager.FindLastTrailIn(trailsList);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FindLastTrailIn_TestData_ExpectedBehaviour()
        {
            var obj1 = new Trail();
            obj1.day = 3;
            obj1.month = 1;
            obj1.year = 2020;

            var obj2 = new Trail();
            obj2.day = 1;
            obj2.month = 1;
            obj2.year = 2020;

            var obj3 = new Trail();
            obj3.day = 1;
            obj3.month = 2;
            obj3.year = 2021;
            var trailsList = new List<Trail>();
            trailsList.Add(obj1);
            trailsList.Add(obj2);
            trailsList.Add(obj3);

            var result = TrailsManager.FindLastTrailIn(trailsList).DaysPast2020();

            Assert.AreEqual(result, obj3.DaysPast2020());
        }

    }
}
