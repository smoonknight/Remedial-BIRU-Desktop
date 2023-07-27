using Remedial_BIRU.DataCollections;
using System;
using System.Collections.Generic;

namespace Remedial_BIRU.Classes.Algoritms
{
    class TravelingSalesmanProblem
    {
        public static List<TravelingSalesmanProblemData> NearestNeighborTSP(List<TravelingSalesmanProblemData> points)
        {
            List<TravelingSalesmanProblemData> unvisited = new List<TravelingSalesmanProblemData>(points);
            List<TravelingSalesmanProblemData> route = new List<TravelingSalesmanProblemData>();
            TravelingSalesmanProblemData current = unvisited[0];

            unvisited.Remove(current);
            route.Add(current);

            while (unvisited.Count > 0)
            {
                TravelingSalesmanProblemData nearestNeighbor = FindNearestNeighbor(current, unvisited);
                current = nearestNeighbor;
                unvisited.Remove(current);
                route.Add(current);
            }

            route.Add(route[0]);

            return route;
        }

        public static TravelingSalesmanProblemData FindNearestNeighbor(TravelingSalesmanProblemData origin, List<TravelingSalesmanProblemData> candidates)
        {
            double minDistance = double.MaxValue;
            TravelingSalesmanProblemData nearestNeighbor = null;

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

        public static double Haversine(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            const double R = 6371.0;

            double dLatitude = (latitude2 - latitude1) * (Math.PI / 180.0);
            double dLongitude = (longitude2 - longitude1) * (Math.PI / 180.0);
            double calculate = Math.Sin(dLatitude / 2) * Math.Sin(dLatitude / 2) +
                       Math.Cos(latitude1 * (Math.PI / 180.0)) * Math.Cos(latitude2 * (Math.PI / 180.0)) *
                       Math.Sin(dLongitude / 2) * Math.Sin(dLongitude / 2);
            double finalCalculate = 2 * Math.Atan2(Math.Sqrt(calculate), Math.Sqrt(1 - calculate));
            double distance = R * finalCalculate;

            return distance;
        }

        public static double CalculateTotalDistance(List<TravelingSalesmanProblemData> route)
        {
            double totalDistance = 0;
            for (int i = 0; i < route.Count - 1; i++)
            {
                totalDistance += Haversine(route[i].Latitude, route[i].Longitude, route[i + 1].Latitude, route[i + 1].Longitude);
            }
            return totalDistance;
        }
    }
}