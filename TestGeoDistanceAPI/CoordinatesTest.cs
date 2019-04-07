using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GeoDistanceAPI.Models;

namespace TestGeoDistanceAPI
{
    [TestClass]
    public class CoordinatesTest
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
            //Arrange & Act
            Coordinates coordinatesA = new Coordinates(LatitudeA, LongitudeA);

            //Assert
            Assert.IsNotNull(coordinatesA, nameof(coordinatesA));
        }

        /// <summary>
        /// tests that the Coordinates property is set properly on construction
        /// </summary>
        [TestMethod]
        public void Test_Coordinates_AreSetCorrectly()
        {
            //Arrange and Act
            Coordinates coordinatesA = new Coordinates(LatitudeA, LongitudeA);

            //Assert
            Assert.AreEqual(LatitudeA, coordinatesA.Latitude, nameof(LatitudeA));
            Assert.AreEqual(LongitudeA, coordinatesA.Longitude, nameof(LongitudeA));
        }

        #endregion
    }
}
