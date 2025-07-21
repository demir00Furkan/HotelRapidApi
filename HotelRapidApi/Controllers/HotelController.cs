using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HotelRapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static HotelRapidApi.Models.HotelDetailViewModel;
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
                

                // 1. Şehirden dest_id al
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={Uri.EscapeDataString(city)}"),
                    Headers =
                    {
                        { "x-rapidapi-key", "910852c028msh86b144cbcbe6312p19fe40jsnee74c5ed8b47" },
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
                        RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={destId}&search_type=CITY&arrival_date={dateIn}&departure_date={dateOut}&adults={guest}&children_age={children}&units=metric&temperature_unit=c&languagecode=en-us&currency_code=USD&location=US"),
                        Headers =
                        {
                            { "x-rapidapi-key", "910852c028msh86b144cbcbe6312p19fe40jsnee74c5ed8b47" },
                            { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                        }
                    };

                    using (var hotelResponse = await client.SendAsync(hotelRequest))
                    {
                        hotelResponse.EnsureSuccessStatusCode();
                        var hotelBody = await hotelResponse.Content.ReadAsStringAsync();
                        var hotelData = JsonConvert.DeserializeObject<HotelViewModel.Rootobject>(hotelBody);

                        hotels = hotelData?.data?.hotels?.ToList() ?? new List<HotelViewModel.Hotel>();
                        ViewBag.a = guest;
                        ViewBag.b = children;

                    }
                }
            }
            catch
            {
                hotels = new List<HotelViewModel.Hotel>();
            }
            return View(hotels);
        }


        public async Task<IActionResult> HotelDetail(int id, string dateIn, string dateOut, int guest, int children)
        {

            int roomQuantity = (int)Math.Ceiling((double)guest / 2);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelDetails?hotel_id={id}&arrival_date={dateIn}&departure_date={dateOut}&adults={guest}&children_age={children}&room_qty={roomQuantity}&units=metric&temperature_unit=c&languagecode=tr&currency_code=USD"),
                Headers =
    {
        { "x-rapidapi-key", "910852c028msh86b144cbcbe6312p19fe40jsnee74c5ed8b47" },
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
        { "x-rapidapi-key", "910852c028msh86b144cbcbe6312p19fe40jsnee74c5ed8b47" },
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
            ViewBag.adult = guest;
            ViewBag.child = children;
            ViewBag.rquest= request;
            return View(viewModel);



        }




    }
}