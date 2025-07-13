using System;
using HotelRapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static HotelRapidApi.Models.HotelViewModel;

namespace HotelRapidApi.Controllers
{
    public class HotelController : Controller
    {
        public async Task<IActionResult> HotelList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-2092174&search_type=CITY&arrival_date=2025-07-12&departure_date=2025-07-19&units=metric&temperature_unit=c&languagecode=en-us&currency_code=USD&location=US"),
                Headers =
    {
        { "x-rapidapi-key", "421f8074eamshabe15fc5d597ea2p138e32jsn0eaea20bac41" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HotelViewModel.Rootobject>(body);
                return View(values.data.hotels.ToList());
            }
        }

        public async Task<IActionResult> HotelDetail(int id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-2092174&search_type=CITY&arrival_date=2025-07-12&departure_date=2025-07-19&units=metric&temperature_unit=c&languagecode=en-us&currency_code=USD&location=US"),
                Headers =
    {
        { "x-rapidapi-key", "421f8074eamshabe15fc5d597ea2p138e32jsn0eaea20bac41" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HotelViewModel.Rootobject>(body);

                if (values?.data?.hotels != null)
                {
                    // ID'ye göre oteli bul
                    var selectedHotel = values.data.hotels.FirstOrDefault(h => h.hotel_id == id);

                    if (selectedHotel != null)
                    {
                        return View(selectedHotel);
                    }
                }

                return NotFound("Otel bulunamadı");
            }
        }
    }
}