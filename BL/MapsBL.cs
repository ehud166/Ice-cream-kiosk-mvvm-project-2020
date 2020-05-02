using BingMapsRESTToolkit;
using DAL;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MapsBL
    {
        MapsService mapsService = new MapsService();
        public async Task<LocationCollection> GetRouteAsLocations(List<SimpleWaypoint> waypoints, string bingMapsKey, TravelModeType travelModeType)
        {
            return await mapsService.GetRouteAsLocations(waypoints, bingMapsKey, travelModeType);
        }
    }
}
