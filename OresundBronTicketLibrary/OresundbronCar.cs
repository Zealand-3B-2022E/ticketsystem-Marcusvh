using TicketSystemClassLibrary;

namespace OresundBronTicketLibrary
{
    public class OresundbronCar: Car
    {
        
        public override double Price(bool broBizz)
        {
            return broBizz ? 161 : 410;
        }
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}