using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeTrailManager.UserControls;

namespace BikeTrailManager.UnitTests.Controls
{
    //Uncomment TestClass if you want to test methods with message boxes
    //[TestClass]
    public class AddTrailControlTests
    {
        [TestMethod]
        public void CheckValidation_BadYear_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1";
            string elevationGain = "1";
            string hours = "1";
            string minutes = "1";
            string day = "1";
            string month = "1";
            string year = "-1"; //incorrect value
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadMonth_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1";
            string elevationGain = "1";
            string hours = "1";
            string minutes = "1";
            string day = "1";
            string month = "13";//incorrect value
            string year = "1";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadDay_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1";
            string elevationGain = "1";
            string hours = "1";
            string minutes = "1";
            string day = "32";//incorrect value
            string month = "1";
            string year = "1";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadMinutes_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1";
            string elevationGain = "1";
            string hours = "1";
            string minutes = "something"; //incorrect value
            string day = "1";
            string month = "1";
            string year = "1";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadHours_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1";
            string elevationGain = "1";
            string hours = "something"; //incorrect value
            string minutes = "1";
            string day = "1";
            string month = "1";
            string year = "1";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadElevationGain_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1";
            string elevationGain = "something"; //incorrect value
            string hours = "1";
            string minutes = "1";
            string day = "1";
            string month = "1";
            string year = "1";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadDistance_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "something"; //incorrect value
            string elevationGain = "1";
            string hours = "1";
            string minutes = "1";
            string day = "1";
            string month = "1";
            string year = "1";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckValidation_BadDayInFebruaryAndNotLeapYear_ExpectedBehaviour()
        {
            //Arrange
            AddTrailControl obj = new AddTrailControl();

            //act
            string name = "Random name";
            string description = "Random description";
            string distance = "1"; 
            string elevationGain = "1";
            string hours = "1";
            string minutes = "1";
            string day = "29";
            string month = "2";
            string year = "2021";
            var result = obj.CheckValidationAndAddTrail(name, description, distance, elevationGain, hours, minutes, day, month, year);

            //assert
            Assert.IsFalse(result);
        }
    }
}
