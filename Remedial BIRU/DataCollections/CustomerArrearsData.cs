using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.DataCollections
{
    class CustomerArrearsData
    {
        public string Name { get; set; }
        public string NoTelp { get; set; }
        public string Information { get; set; }
        public string Status { get; set; }
        public string Ceiling { get; set; }
        public string TotalPayment { get; set; }
        public string Col { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address { get; set; }

        public static CustomerArrearsData[] customerArrearsDatas;
    }
}
