using Remedial_BIRU.DataCollections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remedial_BIRU.Classes.Controllers
{
    public class WhatsappController
    {
        public static string baseWhatsapp(string number) => $"https://wa.me/{number}?text=";
        public static void SendMessageForEmployeeToTravelingRoute(string number, string textMessage)
        {
            textMessage = textMessage.Replace(" ", "%20");
            textMessage = textMessage.Replace("\n", "%0A");
            textMessage = textMessage.Replace("+", "%2B");

            string apiWhatsapp = baseWhatsapp(number) + textMessage;

            Process.Start(apiWhatsapp);
        }


    }
}
