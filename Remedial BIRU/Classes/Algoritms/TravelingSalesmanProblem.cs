using System;

namespace Remedial_BIRU.Classes.Algoritms
{
    class TravelingSalesmanProblem
    {
        static int N = 10; // Jumlah titik lokasi
        public static double[,] distance = new double[N, N]; // Array untuk menyimpan jarak antara titik lokasi

        public struct Point
        {
            public double Latitude;
            public double Longitude;

            public Point(double lat, double lon)
            {
                Latitude = lat;
                Longitude = lon;
            }
        }

        public static double HaversineDistance(Point p1, Point p2)
        {
            double R = 6371;

            double lat1Rad = p1.Latitude * Math.PI / 180.0;
            double lon1Rad = p1.Longitude * Math.PI / 180.0;
            double lat2Rad = p2.Latitude * Math.PI / 180.0;
            double lon2Rad = p2.Longitude * Math.PI / 180.0;

            double dLat = lat2Rad - lat1Rad;
            double dLon = lon2Rad - lon1Rad;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = R * c;
            return distance;
        }

        public static double TSPBruteForce(int[] path, bool[] visited, int current, int count, double currentCost, double minCost)
        {
            if (count == N)
            {
                minCost = Math.Min(minCost, currentCost + distance[current, 0]);
                return minCost;
            }

            for (int i = 0; i < N; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    path[count] = i;

                    double newCost = currentCost + distance[current, i];

                    if (newCost < minCost)
                    {
                        minCost = TSPBruteForce(path, visited, i, count + 1, newCost, minCost);
                    }

                    visited[i] = false;
                }
            }

            return minCost;
        }

        /*static void Main()
        {
            Point[] locations = new Point[]
            {
                new Point(12.5200, 77.8567),
                new Point(19.0760, 72.8777),
                new Point(28.6139, 77.2090),
                new Point(51.5074, 0.1278),
                new Point(40.7128, -74.0060),
                new Point(35.6895, 139.6917),
                new Point(-33.8688, 151.2093),
                new Point(37.7749, -122.4194),
                new Point(37.5665, 126.9780),
                new Point(55.7558, 37.6173)
            };

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    distance[i, j] = HaversineDistance(locations[i], locations[j]);
                }
            }

            int[] shortestPath = new int[N];
            bool[] visited = new bool[N];
            visited[0] = true;

            double minCost = TSPBruteForce(shortestPath, visited, 0, 1, 0, double.MaxValue);

            Console.WriteLine("Rute Terpendek:");
            for (int i = 0; i < N; i++)
            {
                int locationIndex = shortestPath[i];
                Console.WriteLine($"{i + 1}. {locations[locationIndex].Latitude}, {locations[locationIndex].Longitude}");
            }

            Console.WriteLine($"Total Jarak: {minCost} kilometer");
        }*/
    }
}
