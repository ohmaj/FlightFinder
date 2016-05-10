using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flights flights = new Flights();
            Console.WriteLine("What is your destiniation?:");
            string destination = Console.ReadLine();
            foreach (Flight flight in flights.flights)
            {
                if (flight.arrives == destination )
                Console.WriteLine("Flight: "+flight.flight+" to "+flight.arrives+" departs at "+flight.time.ToShortTimeString());
            }
            Console.ReadKey();
        }
    }
}
