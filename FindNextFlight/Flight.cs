using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextFlight
{
    class Flight
     {
        public string flight { get; set; }
        public string departs { get; set; }
        public string arrives { get; set; }
        public DateTime time { get; set; }
        public static Flight Parse(string flightString)
        {
            var fields = flightString.Split(',');
            List<string[]> flightData = new List<string[]>();
            foreach (string field in fields)
            {
                string[] newField = field.Split(';');
                flightData.Add(newField);
            }
            return new Flight
            {
                flight= flightData[0][1], departs= flightData[1][1], arrives = flightData[2][1], time = Convert.ToDateTime(flightData[3][1])
            };
        }
    }
}
