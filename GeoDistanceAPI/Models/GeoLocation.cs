namespace GeoDistanceAPI.Models
{
    /// <summary>
    /// Base class for <see cref="City"/>
    /// </summary>
    /// <author>Muhammad Abubaker</author>
    public abstract class GeoLocation
    {
        #region Properties
        /// <summary>
        /// represents geo coordinates
        /// </summary>
        public Coordinates Coordinates { get; set; }
        #endregion

        /// <summary>
        /// construtor
        /// </summary>
        /// <param name="coordinates"></param>
        public GeoLocation(Coordinates coordinates)
        {
            Coordinates = coordinates;
        }

        #region Methods
        /// <summary>
        /// Abstract method to find distances for two geo graphical locations
        /// </summary>
        /// <param name="otherCoordinates"></param>
        /// <returns>Distance in km</returns>
        /// <remarks> Its Abstract so that the derived class could provide thier own implementation</remarks>
        public abstract double FindDistance(Coordinates otherCoordinates);
        #endregion
    }
}
