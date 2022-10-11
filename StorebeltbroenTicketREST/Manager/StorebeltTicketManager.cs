using StoreBaeltTicketLibrary;

namespace StorebeltbroenTicketREST.Manager
{
    public class StorebeltTicketManager
    {
        private static List<Storebaelt> listOfCarTickets = new();


        public StorebeltTicketManager()
        {
            Storebaelt car1 = new();
            car1.Licenseplate = "12345";
            car1.Brobizz = true;

            listOfCarTickets.Add(car1);
        }
        public Storebaelt AddCar(Storebaelt sCar)
        {
            if (sCar == null || sCar.Licenseplate == null)
                throw new ArgumentNullException("To create a Car it needs to have infomations");
            if (listOfCarTickets.Contains(sCar))
                throw new ArgumentException("A car with those infomations allready exist.");

            listOfCarTickets.Add(sCar);
            return sCar;
        }

        public List<Storebaelt> AllCarTicketes()
        {
            if (listOfCarTickets.Count == 0)
                throw new ArgumentException("The list of cars does not contain any");

            return listOfCarTickets;
        }
        public List<Storebaelt> GetFromLicensePlate(string lp)
        {
            if (String.IsNullOrWhiteSpace(lp))
                throw new ArgumentNullException("You need to specifies a License Plate");

            List<Storebaelt> cars = listOfCarTickets.FindAll(k => k.Licenseplate == lp);
            if (cars.Count == 0)
                throw new ArgumentException("Did not find any cars that matches that license plate");

            return cars;
        }
    }
}
