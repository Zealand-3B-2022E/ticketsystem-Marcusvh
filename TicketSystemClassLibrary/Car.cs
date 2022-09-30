namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Class that handles a Car
    /// </summary>
    public class Car: Vehicle
    {
        /// <summary>
        /// Price for a car to travel through with or without BroBizz
        /// </summary>
        /// <returns>Price in DKK</returns>
        public double Price(bool broBizz)
        {
            return Vehicle.Price(240, broBizz);
        } 
        /// <summary>
        /// Price for a car to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public double Price()
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