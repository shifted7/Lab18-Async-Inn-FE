using Async_Inn_Frontend.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Async_Inn_Frontend.Models.Services
{
    public class HotelService : IHotelManager
    {
        private static readonly HttpClient client = new HttpClient();
        public string baseURL = @"https://localhost:44325/api";
        public async Task<List<Hotel>> GetAllHotels()
        {
            string route = "hotels";
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var streamTask = await client.GetStreamAsync($"{baseURL}/{route}");
            var result = await JsonSerializer.DeserializeAsync<List<Hotel>>(streamTask);
            return result;
        }

        public async Task<Hotel> GetHotelById(int hotelId)
        {
            throw new NotImplementedException();
        }
    }
}
