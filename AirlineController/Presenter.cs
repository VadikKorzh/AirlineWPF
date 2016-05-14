using AirlineModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinePresenter
{
    public class Presenter
    {
        IView _view;
        IAirline _airlineModel;

        public Presenter(IView view)
        {
            _view = view;
            _airlineModel = AirlineFactory.CreateAirline();

            _view.PopulateGrid += PopulateGrid;
            _view.DeleteFlights += DeleteFlights;
        }

        private void DeleteFlights(object sender, FlightEventArgs e)
        {
            _airlineModel.DeleteFlights(e.Flights);
        }

        private void PopulateGrid(object sender, EventArgs e)
        {
            _view.ShowFlights(_airlineModel.Flights);
        }
    }
}
