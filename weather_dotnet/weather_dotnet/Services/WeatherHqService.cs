using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using weather_dotnet.Models;

namespace weather_dotnet.Services
{

    public class WeatherHqServices
    {

        private static SynchronizationContext synchronizationContext;
        // TODO: adicionar &key="sua_key" abaixo
        private const string endpoint = "https://api.hgbrasil.com/weather?format=json-cors&city_name=Campinas,SP"; 
        
        public WeatherHqServices()
        {
        }

        public async Task<Weather> GetTemperatureMaxAsync()
        {
            WeatherResponse response = (await endpoint.GetJsonAsync<WeatherResponse>());

            return response.results;
        }
    }
}
