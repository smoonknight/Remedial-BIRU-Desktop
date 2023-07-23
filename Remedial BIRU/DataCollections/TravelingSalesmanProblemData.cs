using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.DataCollections
{
    class TravelingSalesmanProblemData
    {
        public CustomerArrearsData Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public TravelingSalesmanProblemData(CustomerArrearsData customerArrearsData, double latitude, double longitude)
        {
            Name = customerArrearsData;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
