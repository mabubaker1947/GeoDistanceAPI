using System;

namespace GeoDistanceAPI.Models
{
    /// <summary>
    /// Holds information of a geo location/City
    /// </summary>
    /// <author>Muhammad Abubaker</author>
    public class City : GeoLocation
    {
        #region Properties
        /// <summary>
        /// Radius of Earth in km
        /// </summary>
        private const int EarthRadius = 6371;
        #endregion


        #region Constructors
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="coordinates">geo coordinates for this city</param>
        public City(Coordinates coordinates) :base(coordinates) { }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates geo distance from the current city to the other city
        /// </summary>
        /// <param name="otherCoordinates">coordinates of other city</param>
        /// <returns>Distance in km</returns>
        public override double FindDistance(Coordinates otherCoordinates)
        {
            var latitude1 = this.Coordinates.Latitude;
            var latitude2 = otherCoordinates.Latitude;

            var longitude1 = this.Coordinates.Longitude;
            var longitude2 = otherCoordinates.Longitude;

            double f1 = ConvertToRadians(latitude1);
            double f2 = ConvertToRadians(latitude2);

            double deltaLatitude = ConvertToRadians(latitude1 - latitude2);
            double deltaLongitude = ConvertToRadians(longitude1 - longitude2);

            double a = Math.Sin(deltaLatitude / 2) * Math.Sin(deltaLatitude / 2) +
                        Math.Cos(f1) * Math.Cos(f2) *
                        Math.Sin(deltaLongitude / 2) * Math.Sin(deltaLongitude / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Calculate the distance.
            double d = EarthRadius * c;

            return d;
        }
        #endregion

        #region PrivateMethods
        /// <summary>
        /// Converts coordinated angle to a Radian units
        /// </summary>
        /// <param name="coordinateAngle">coordinated angle of a city</param>
        /// <returns>Radian angle</returns>
        private double ConvertToRadians(double coordinateAngle)
        {
            return (Math.PI / 180) * coordinateAngle;
        }
        #endregion

    }
}
