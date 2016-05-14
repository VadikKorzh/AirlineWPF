using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineModel
{
    public class Airline : IAirline
    {
        public IEnumerable<Flight> Flights { get; }

        public Airline()
        {
            Flights = new List<Flight>{
                new Flight { Number = 1, Destination = "Monaco", Direction = 0},
                new Flight { Number = 4, Destination = "NY", Direction = 0},
                new Flight { Number = 100, Destination = "Beijing", Direction = 1}
            };
        }

        public void DeleteFlights(IEnumerable<Flight> flightsToDelete)
        {
            foreach (var flight in flightsToDelete)
            {
                ((List<Flight>)Flights).Remove(flight);
            }
        }
    }
}
