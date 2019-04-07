namespace GeoDistanceAPI.Models
{
    /// <summary>
    /// Class that holds Geo Cordinates of a location
    /// </summary>
    /// <author>Muhammad Abubaker</author>
    public class Coordinates
    {
        #region Properties
        /// <summary>
        /// Latitude of a geo location
        /// </summary>
        public double Latitude { get; set; }
        
        /// <summary>
        /// Longitude of a geo location
        /// </summary>
        public double Longitude { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="latitude">latitude of a geo location</param>
        /// <param name="longitude">longitude of a geo location</param>
        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Coordinates()
        {
        }
        #endregion
    }
}
