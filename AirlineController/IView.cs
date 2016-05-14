using AirlineModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinePresenter
{
    public interface IView
    {
        void ShowFlights(IEnumerable<Flight> flights);

        event EventHandler PopulateGrid;
        event EventHandler<FlightEventArgs> DeleteFlights;
    }
}
