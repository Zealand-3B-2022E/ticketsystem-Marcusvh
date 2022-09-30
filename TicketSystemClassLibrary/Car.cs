namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Class that handles a Car
    /// </summary>
    public class Car: Vehicle
    {
        /// <summary>
        /// Price for a car to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public override double Price()
        {
            return 240;
        } 

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public override string VehicleType()
        {
            return "Car";
        } 


    }
}