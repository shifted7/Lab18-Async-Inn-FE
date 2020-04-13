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
        public string baseURL = @"https://asyncinn-andrewharry-api.azurewebsites.net/api"; // URL of backend
        
        /// <summary>
        /// Gets a list of all our hotel objects from the backend
        /// </summary>
        /// <returns>A task to asynchronously provide a list of hotels</returns>
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
            string route = $"hotels/{hotelId}";
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var streamTask = await client.GetStreamAsync($"{baseURL}/{route}");
            var result = await JsonSerializer.DeserializeAsync<Hotel>(streamTask);
            return result;
        }
    }
}
