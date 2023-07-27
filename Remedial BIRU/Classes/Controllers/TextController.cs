using Remedial_BIRU.DataCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.Classes.Controllers
{
    class TextController
    {
        public static string MessageToEmployeeTravelingRoute(TravelingSalesmanProblemData travelingSalesmanProblemData)
        {
            string name = travelingSalesmanProblemData.customerArrearsData.name;
            string address = travelingSalesmanProblemData.customerArrearsData.address;
            string contactNumber = travelingSalesmanProblemData.customerArrearsData.contactNumber;
            string daysInArrears = travelingSalesmanProblemData.customerArrearsData.daysInArrears;
            string dueDate = travelingSalesmanProblemData.customerArrearsData.dueDate;
            string ceiling = travelingSalesmanProblemData.customerArrearsData.ceiling;
            string totalPayment = travelingSalesmanProblemData.customerArrearsData.totalPayment;
            string col = travelingSalesmanProblemData.customerArrearsData.col;
            string latitude = travelingSalesmanProblemData.customerArrearsData.latitude.ToString();
            string longitude = travelingSalesmanProblemData.customerArrearsData.longitude.ToString();

            string dataCustomerText = $"Nama Nasahah : {name}\n" +
                                      $"Alamat : {address}\n" +
                                      $"Nomor HP : {contactNumber}\n" +
                                      $"Hari Tertunggak : {daysInArrears}\n" +
                                      $"Jatuh Tempo : {dueDate}\n" +
                                      $"Plafon : {ceiling}\n" +
                                      $"Total Tunggakan : {totalPayment}\n" +
                                      $"Col : {col}\n" +
                                      $"Latitude : {latitude}\n" +
                                      $"Longitude : {longitude}\n";

            if (travelingSalesmanProblemData.customerArrearsData.contactNumber == null)
            {
                return dataCustomerText;
            }
            string whatsapp = "https://wa.me/" + (contactNumber.First() == '+' ? contactNumber : ConvertPhoneNumber(contactNumber, "+62"));
            dataCustomerText += $"Link Whatsapp : {whatsapp}";

            return dataCustomerText;
        }

        public static string MessageToEmployeeTravelingRouteAllCustomer(List<TravelingSalesmanProblemData> travelingSalesmanProblemDatas)
        {
            string dataCustomersText = "";
            int increment = 0;
            foreach (TravelingSalesmanProblemData travelingSalesmanProblemData in travelingSalesmanProblemDatas)
            {
                increment++;
                string routeNumber = $"Rute ke - {increment}";
                string name = travelingSalesmanProblemData.customerArrearsData.name;
                string address = travelingSalesmanProblemData.customerArrearsData.address;
                string contactNumber = travelingSalesmanProblemData.customerArrearsData.contactNumber;
                string whatsappNumber = (contactNumber.First() == '+' ? contactNumber : ConvertPhoneNumber(contactNumber, "+62"));
                string latitude = travelingSalesmanProblemData.customerArrearsData.latitude.ToString();
                string longitude = travelingSalesmanProblemData.customerArrearsData.longitude.ToString();

                string textBuilder = $"Nama Nasahah : {name}\n" +
                              $"Alamat : {address}\n" +
                              $"Whatsapp link : wa.me/{whatsappNumber}\n" +
                              $"{latitude}, {longitude}\n\n";

                dataCustomersText += textBuilder;
            }

            return dataCustomersText;
        }
        public static string ConvertPhoneNumber(string basePhoneNumber, string countryCode)
        {
            if (basePhoneNumber.StartsWith("0"))
            {
                basePhoneNumber = basePhoneNumber.Substring(1);
            }

            string phoneNumberWithCountryCode = countryCode + basePhoneNumber;
            return phoneNumberWithCountryCode;
        }
    }
}
