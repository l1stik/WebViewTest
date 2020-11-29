using System.Net;

namespace TestTaskMpulseProjectMaterials.Scripts.Essences
{
    public static class GeoService
    {
        public static string GetUserLocation()
        {
            const string urlGetCountry = "http://ip-api.com/line/?fields=country";
           
            return new WebClient().DownloadString(urlGetCountry).Trim();
        }
    }
}