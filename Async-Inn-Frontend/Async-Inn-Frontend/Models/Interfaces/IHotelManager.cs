using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_Frontend.Models.Interfaces
{
    public interface IHotelManager
    {
        public Task<List<Hotel>> GetAllHotels();
        public Task<Hotel> GetHotelById(int hotelId);
    }
}
