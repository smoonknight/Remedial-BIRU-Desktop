using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.DataCollections
{
    public class CustomerArrearsData
    {
        public string uid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public string daysInArrears { get; set; }
        public string dueDate { get; set; }
        public string ceiling { get; set; }
        public string totalPayment { get; set; }
        public string col { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string linkGoogleMaps { get; set; }
    }

    class CustomerArrearsDataCollection
    {
        public static List<CustomerArrearsData> customerArrearsDatas = new List<CustomerArrearsData>();
    }
}