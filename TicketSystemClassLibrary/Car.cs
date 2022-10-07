namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Class that handles a Car
    /// </summary>
    public class Car: Vehicle
    {
        public int BrobizzDiscountAmount { get; set; } = 5;
        public int WeekendDiscountAmount { get; set; } = 20;

        /// <summary>
        /// Price for a car to travel through with or without BroBizz and weekend discount
        /// </summary>
        /// <returns>Price in DKK</returns>
        public double Price(bool broBizz)
        {
            double price = 240;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
                price = 240 * (1 - (WeekendDiscountAmount / 100.0));

            return broBizz ? price * (1 - (BrobizzDiscountAmount / 100.0)) : 240;
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