using BingMapsRESTToolkit;
using BingMapsRESTToolkit.Extensions;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MapsService
    {
        
        public async Task<Route> GetRoute(List<SimpleWaypoint> waypoints,  string bingMapsKey, TravelModeType travelModeType = TravelModeType.Walking)
        {
            var routeRequest = new RouteRequest()
            {
                Waypoints = waypoints,

                //Specify that we want the route to be optimized.
                WaypointOptimization = TspOptimizationType.TravelDistance,

                RouteOptions = new RouteOptions()
                {
                    Heading = 1,
                    MaxSolutions = 1,
                    Optimize = RouteOptimizationType.Time,
                    TravelMode = travelModeType,
                    RouteAttributes = new List<RouteAttributeType>()
                        {
                        RouteAttributeType.RoutePath,
                        RouteAttributeType.ExcludeItinerary
                    }
                },

                //When straight line distances are used, the distance matrix API is not used, so a session key can be used.
                BingMapsKey = bingMapsKey
            };

            var response = await routeRequest.Execute();
            if (response != null && response.ResourceSets != null && response.ResourceSets.Length > 0 &&
                response.ResourceSets[0].Resources != null && response.ResourceSets[0].Resources.Length > 0
                     && response.ResourceSets[0].Resources[0] is Route)
            {
                var route = response.ResourceSets[0].Resources[0] as Route;
                return route;
            }
            else if (response != null && response.ErrorDetails != null && response.ErrorDetails.Length > 0)
            {
                throw new Exception(String.Join("", response.ErrorDetails));
            }
            return null;

        }

        public async Task<LocationCollection> GetRouteAsLocations(List<SimpleWaypoint> waypoints, string bingMapsKey, TravelModeType travelModeType = TravelModeType.Walking)
        {
            await SimpleWaypoint.TryGeocodeWaypoints(waypoints, bingMapsKey);
            var route = await GetRoute(waypoints, bingMapsKey, travelModeType);

            var routeLine = route.RoutePath.Line.Coordinates;
            var routePath = new LocationCollection();

            for (int i = 0; i < routeLine.Length; i++)
            {
                routePath.Add(new Microsoft.Maps.MapControl.WPF.Location(routeLine[i][0], routeLine[i][1]));
            }

            return routePath;
        }


    }
}
