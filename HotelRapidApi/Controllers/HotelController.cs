using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HotelRapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static HotelRapidApi.Models.HotelViewModel;

namespace HotelRapidApi.Controllers
{
    public class HotelController : Controller
    {
        HotelDetailViewModel detailResult = null;
        HotelPhotoViewModel.Rootobject photoResult = null;

        [HttpGet]
        public async Task<IActionResult> HotelList()
        {
            return View(new List<HotelViewModel.Hotel>());
        }

        [HttpPost]
        public async Task<IActionResult> HotelList(string city, string dateIn, string dateOut, int guest, int children, string photo)
        {
            var hotels = new List<HotelViewModel.Hotel>();
            try
            {
                string destId = null;
                string childrenAgeString = children > 0 ? "&children_age=" + string.Join("%2C", Enumerable.Repeat("5", children)) : "";

                // 1. Şehirden dest_id al
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={Uri.EscapeDataString(city)}"),
                    Headers =
                    {
                        { "x-rapidapi-key", "4b0a875cb4mshed6ab714d48a40ep1f44c5jsnd1d6dbede527" },
                        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                    },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<HotelDestViewModel.Rootobject>(body);
                    destId = values?.data?.FirstOrDefault()?.dest_id;
                    ViewBag.detsid = destId;
                }

                if (!string.IsNullOrEmpty(destId))
                {
                    // 2. dest_id ile otelleri getir
                    var hotelRequest = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={destId}&search_type=CITY&arrival_date={dateIn}&departure_date={dateOut}&adults={guest}{childrenAgeString}&units=metric&temperature_unit=c&languagecode=tr&currency_code=TRY"),
                        Headers =
                        {
                            { "x-rapidapi-key", "4b0a875cb4mshed6ab714d48a40ep1f44c5jsnd1d6dbede527" },
                            { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                        }
                    };

                    using (var hotelResponse = await client.SendAsync(hotelRequest))
                    {
                        hotelResponse.EnsureSuccessStatusCode();
                        var hotelBody = await hotelResponse.Content.ReadAsStringAsync();
                        var hotelData = JsonConvert.DeserializeObject<HotelViewModel.Rootobject>(hotelBody);

                        hotels = hotelData?.data?.hotels?.ToList() ?? new List<HotelViewModel.Hotel>();
                    }
                }
            }
            catch
            {
                hotels = new List<HotelViewModel.Hotel>();
            }
            return View(hotels);
        }


        public async Task<IActionResult> HotelDetail(int id, string dateIn, string dateOut, string guest, string children)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelDetails?hotel_id={id}&arrival_date=2025-07-18&departure_date=2025-07-25&adults=1&children_age=1%2C17&room_qty=1&units=metric&temperature_unit=c&languagecode=tr&currency_code=TRY"),

                Headers =
    {
        { "x-rapidapi-key", "4b0a875cb4mshed6ab714d48a40ep1f44c5jsnd1d6dbede527" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                detailResult = JsonConvert.DeserializeObject<HotelDetailViewModel>(body);

            }


            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelPhotos?hotel_id={id}"),
                Headers =
    {
        { "x-rapidapi-key", "4b0a875cb4mshed6ab714d48a40ep1f44c5jsnd1d6dbede527" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request2))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                photoResult = JsonConvert.DeserializeObject<HotelPhotoViewModel.Rootobject>(body);

            }
            var viewModel = new HotelPageViewModel
            {
                HotelDetail = detailResult.data,
                HotelPhotos = photoResult.data.ToList()

            };
            return View(viewModel);



        }




    }
}








