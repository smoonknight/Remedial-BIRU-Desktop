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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTravelingSalesmanProblemAlgoritm();
        }
        
        private void StartTravelingSalesmanProblemAlgoritm()
        {
            List<Classes.Algoritms.Point> points = new List<Classes.Algoritms.Point>();

            foreach (CustomerArrearsData data in CustomerArrearsDataCollection.customerArrearsDatas)
            {
                points.Add(new Classes.Algoritms.Point(data, data.latitude, data.longitude));
            }

            List<Classes.Algoritms.Point> shortestRoute = TravelingSalesmanProblem.NearestNeighborTSP(points);

            foreach (var point in shortestRoute)
            {
                Console.WriteLine($"{point.Name} ({point.Latitude}, {point.Longitude})");
            }

            double totalDistance = TravelingSalesmanProblem.CalculateTotalDistance(shortestRoute);
            Console.WriteLine($"Total jarak: {totalDistance} kilometer");
        }
    }
}
