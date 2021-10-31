using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CoreForDemoWithLogin.Models;

namespace CoreForDemoWithLogin.Controller
{
    public class HomePageAPI
    {
        public async Task<IEnumerable<NewModel>> GetNewAsync(string path, string homeApiCon)
        {
            IEnumerable<NewModel> newList = null;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var httpClient = new HttpClient(clientHandler))
            {
                httpClient.BaseAddress = new Uri(homeApiCon);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    newList = await response.Content.ReadAsAsync<IEnumerable<NewModel>>();
                }
            }

            return newList;
        }


        public async Task<IEnumerable<BannerModel>> GetBannerAsync(string path, string homeApiCon)
        {
            IEnumerable<BannerModel> bannerList = null;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var httpClient = new HttpClient(clientHandler))
            {
                httpClient.BaseAddress = new Uri(homeApiCon);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    bannerList = await response.Content.ReadAsAsync<IEnumerable<BannerModel>>();
                }
            }

            return bannerList;
        }

        public async Task<IEnumerable<EventModel>> GetEventAsync(string path, string homeApiCon)
        {
            IEnumerable<EventModel> eventList = null;
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var httpClient = new HttpClient(clientHandler))
            {
                httpClient.BaseAddress = new Uri(homeApiCon);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    eventList = await response.Content.ReadAsAsync<IEnumerable<EventModel>>();
                }
            }

            return eventList;
        }
    }
}
