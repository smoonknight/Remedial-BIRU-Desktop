using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.DataCollections
{
    public class TravelingSalesmanProblemData
    {
        public CustomerArrearsData customerArrearsData { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public TravelingSalesmanProblemData(CustomerArrearsData customerArrearsData, double latitude, double longitude)
        {
            this.customerArrearsData = customerArrearsData;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
