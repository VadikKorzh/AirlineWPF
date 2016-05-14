using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineModel
{
    public interface IAirline
    {
        IEnumerable<Flight> Flights { get; }
        void DeleteFlights(IEnumerable<Flight> flightsToDelete);
    }
}
