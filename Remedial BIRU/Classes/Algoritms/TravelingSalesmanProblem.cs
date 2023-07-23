using Remedial_BIRU.DataCollections;
using System;
using System.Collections.Generic;

namespace Remedial_BIRU.Classes.Algoritms
{
    class TravelingSalesmanProblem
    {
        public static List<Point> NearestNeighborTSP(List<Point> points)
        {
            List<Point> unvisited = new List<Point>(points);
            List<Point> route = new List<Point>();
            Point current = unvisited[0]; // Pilih titik awal (misalnya, titik pertama dalam daftar)

            unvisited.Remove(current);
            route.Add(current);

            while (unvisited.Count > 0)
            {
                Point nearestNeighbor = FindNearestNeighbor(current, unvisited);
                current = nearestNeighbor;
                unvisited.Remove(current);
                route.Add(current);
            }

            // Kembali ke titik awal untuk menyelesaikan rute
            route.Add(route[0]);

            return route;
        }

        public static Point FindNearestNeighbor(Point origin, List<Point> candidates)
        {
            double minDistance = double.MaxValue;
            Point nearestNeighbor = null;

            foreach (var candidate in candidates)
            {
                double distance = Haversine(origin.Latitude, origin.Longitude, candidate.Latitude, candidate.Longitude);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestNeighbor = candidate;
                }
            }

            return nearestNeighbor;
        }

        // Rumus haversine untuk menghitung jarak antara dua titik koordinat
        public static double Haversine(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371.0; // Radius bumi dalam kilometer

            double dLat = (lat2 - lat1) * (Math.PI / 180.0);
            double dLon = (lon2 - lon1) * (Math.PI / 180.0);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1 * (Math.PI / 180.0)) * Math.Cos(lat2 * (Math.PI / 180.0)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = R * c;

            return distance;
        }

        public static double CalculateTotalDistance(List<Point> route)
        {
            double totalDistance = 0;
            for (int i = 0; i < route.Count - 1; i++)
            {
                totalDistance += Haversine(route[i].Latitude, route[i].Longitude, route[i + 1].Latitude, route[i + 1].Longitude);
            }
            return totalDistance;
        }
    }
    public class Point
    {
        public CustomerArrearsData Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Point(CustomerArrearsData customerArrearsData, double latitude, double longitude)
        {
            Name = customerArrearsData;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
