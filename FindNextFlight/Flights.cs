using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindNextFlight
{
    class Flights
    {
        public IEnumerable<Flight> flights;

        public Flights()
            {
            this.flights = createFlights();
            }
        public IEnumerable<Flight> createFlights()
        {
            IEnumerable<string> flightStrings = File.ReadLines(@"flightinfo.txt");
            foreach (string flightString in flightStrings)
            {
                Flight flight = Flight.Parse(flightString);
                yield return flight;


            }
        }
    }
}
