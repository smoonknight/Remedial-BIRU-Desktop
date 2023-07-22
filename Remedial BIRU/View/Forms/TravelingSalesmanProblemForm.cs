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
            TravelingSalesmanProblem travelingSalesmanProblem = new TravelingSalesmanProblem();
            TravelingSalesmanProblem.Point[] locations = new TravelingSalesmanProblem.Point[]
            {
                new TravelingSalesmanProblem.Point(12.5200, 77.8567),
                new TravelingSalesmanProblem.Point(19.0760, 72.8777),
                new TravelingSalesmanProblem.Point(28.6139, 77.2090),
                new TravelingSalesmanProblem.Point(51.5074, 0.1278),
                new TravelingSalesmanProblem.Point(40.7128, -74.0060),
                new TravelingSalesmanProblem.Point(35.6895, 139.6917),
                new TravelingSalesmanProblem.Point(-33.8688, 151.2093),
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    TravelingSalesmanProblem.distance[i, j] = TravelingSalesmanProblem.HaversineDistance(locations[i], locations[j]);
                }
            }

            int[] shortestPath = new int[10];
            bool[] visited = new bool[10];
            visited[0] = true;

            double minCost = TravelingSalesmanProblem.TSPBruteForce(shortestPath, visited, 0, 1, 0, double.MaxValue);

            Console.WriteLine("Rute Terpendek:");
            for (int i = 0; i < 10; i++)
            {
                int locationIndex = shortestPath[i];
                Console.WriteLine($"{i + 1}. {locations[locationIndex].Latitude}, {locations[locationIndex].Longitude}");
            }

            Console.WriteLine($"Total Jarak: {minCost} kilometer");
        }
    }
}
