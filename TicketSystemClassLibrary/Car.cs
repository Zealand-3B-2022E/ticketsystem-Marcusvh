namespace TicketSystemClassLibrary
{
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// Price for a car to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public double Price()
        {
            return 240;
        } //The price is fixed at 240 which must be returned

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public string VehicleType()
        {
            return "Car";
        }//which returns the string "Car"


    }
}