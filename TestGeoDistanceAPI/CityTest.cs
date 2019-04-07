using System;
using GeoDistanceAPI.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGeoDistanceAPI
{
    /// <summary>
    /// Test class for functionality of <see cref="City"/>
    /// </summary>
    /// <author>Muhammad Abubaker</author>
    [TestClass]
    public class CityTest
    {
        #region PrivateFields
        private const double LatitudeA = 53.297975;
        private const double LongitudeA = -6.372663;
        private const double LatitudeB = 41.385101;
        private const double LongitudeB = -81.440440;
        #endregion

        #region TestMethods
        /// <summary>
        /// Tests that the construction is successfully creating a new object
        /// </summary>
        [TestMethod]
        public void Test_Constructor()
        {
            //Arrange
            Coordinates coordinatesA = new Coordinates(LatitudeA, LongitudeA);

            //Act
            City cityA = new City(coordinatesA);

            //Assert
            Assert.IsNotNull(cityA, nameof(cityA));
        }

        /// <summary>
        /// tests that the Coordinates property is set properly on construction
        /// </summary>
        [TestMethod]
        public void Test_Coordinates_AreSetCorrectly()
        {
            //Arrange
            Coordinates coordinatesA = new Coordinates(LatitudeA, LongitudeA);

            //Act
            City cityA = new City(coordinatesA);

            //Assert
            Assert.AreEqual(LatitudeA, cityA.Coordinates.Latitude, nameof(LatitudeA));
            Assert.AreEqual(LongitudeA, cityA.Coordinates.Longitude, nameof(LongitudeA));
        }

        /// <summary>
        /// Tests that the FindDifference method returns the correct difference in km
        /// </summary>
        [TestMethod]
        public void Test_FindDistance()
        {
            //Arrange
            double expectedDifference = 5536.33868226669;
            Coordinates coordinatesA = new Coordinates(LatitudeA, LongitudeA);
            Coordinates coordinatesB = new Coordinates(LatitudeB, LongitudeB);
            City cityA = new City(coordinatesA);
            City cityB = new City(coordinatesB);

            //Act
            double distanceDifference = cityA.FindDistance(cityB.Coordinates);

            //Assert
            Assert.AreEqual(expectedDifference.ToString(), distanceDifference.ToString(), nameof(expectedDifference));
        }
        #endregion
    }
}
