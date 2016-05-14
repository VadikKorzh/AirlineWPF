using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineModel
{
    public class AirlineFactory
    { 
        static public IAirline CreateAirline()
        {
            return new Airline();
        }
    }
}
