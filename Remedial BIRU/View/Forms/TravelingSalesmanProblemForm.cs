using Remedial_BIRU.Classes.Algoritms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remedial_BIRU.DataCollections;

namespace Remedial_BIRU.View.Forms
{
    public partial class TravelingSalesmanProblemForm : Form
    {
        public TravelingSalesmanProblemForm()
        {
            InitializeComponent();
            StartTravelingSalesmanProblemAlgoritm();
        }

        
        private void StartTravelingSalesmanProblemAlgoritm()
        {
            List<TravelingSalesmanProblemData> points = new List<TravelingSalesmanProblemData>();

            foreach (CustomerArrearsData data in CustomerArrearsDataCollection.customerArrearsDatas)
            {
                points.Add(new TravelingSalesmanProblemData(data, data.latitude, data.longitude));
            }

            List<TravelingSalesmanProblemData> shortestRoute = TravelingSalesmanProblem.NearestNeighborTSP(points);

            foreach (var point in shortestRoute)
            {
                Console.WriteLine($"{point.Name} ({point.Latitude}, {point.Longitude})");
            }

            double totalDistance = TravelingSalesmanProblem.CalculateTotalDistance(shortestRoute);
            Console.WriteLine($"Total jarak: {totalDistance} kilometer");
        }
    }
}
