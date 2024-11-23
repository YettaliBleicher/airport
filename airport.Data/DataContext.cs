using airport.Entities;

namespace airport
{
    public class DataContext
    {
        public List<Airplane> airplanes { get; set; }


        public List<Company> companies { get; set; }

        public List<Flight> flights { get; set; }

        public List<Location> locations { get; set; }

        public List<Status> statuses { get; set; }


        public DataContext()
        {

            flights = new List<Flight> 
            { 
                new Flight{ flightId = 123, airplanId=  1,source = 1,destination = 1, status = 1, takingOffTime = new DateOnly(),landTime = new DateOnly() },
                new Flight{ flightId = 124, airplanId=  1,source = 1,destination = 1, status = 1, takingOffTime = new DateOnly(),landTime = new DateOnly() }    
            };

            airplanes = new List<Airplane>
            {
                new Airplane{airplanId = 1, airplaneType = "Jet-plane" }
            };

            companies = new List<Company>
            {
                new Company{companyId = 1, companyName = "EL-AL" }
            };

            locations = new List<Location> 
            {
                new Location{LocationId = 1, LocationName = "Israel" }
            };

            statuses = new List<Status> 
            {
                new Status{statusId = 1, describe = "delay" }
            };
        }
    }
}
