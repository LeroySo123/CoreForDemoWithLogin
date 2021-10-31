using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreForDemoWithLogin.Models;
using CoreForDemoWithLogin.Controller;
using CoreForDemoWithLogin.DTO;
using Microsoft.Extensions.Options;
using System.Globalization;


namespace CoreForDemoWithLogin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        AppSettings settings;

        public IndexModel(ILogger<IndexModel> logger, IOptions<AppSettings> _settings)
        {
            _logger = logger;
            settings = _settings.Value;
        }

        public List<NewModel> News { get; set; }
        public List<LinkModel> Links { get; set; }
        public List<BannerModel> Banners { get; set; }
        public List<EventDTO> Events { get; set; }

        public void OnGet()
        {

            var homeApiCon = settings.HomeAPIConnection;

            HomePageAPI homePageAPI = new HomePageAPI();
            var allNews = homePageAPI.GetNewAsync("/api/HomePageNew", homeApiCon).GetAwaiter().GetResult();
            var allBanner = homePageAPI.GetBannerAsync("/api/HomePageBanner", homeApiCon).GetAwaiter().GetResult();
            var allEvent = homePageAPI.GetEventAsync("/api/HomePageEvent", homeApiCon).GetAwaiter().GetResult();


            if (allNews != null)
            {
                this.News = allNews.Where(x => x.ActiveDate <= DateTime.Today.Date).OrderByDescending(x => x.ActiveDate).Take(3).ToList();
            }
            else
            {
                List<NewModel> nullNew = new List<NewModel>();
                this.News = nullNew;
            }

            /*
            foreach (NewModel newitem in News)
            {
                string shortNewDetail = ForDisplayWord.TruncateAtWord(newitem.NewDetail, 100);
                newitem.NewDetail = shortNewDetail;
            }
            */

            if (allBanner != null)
            {
                this.Banners = allBanner.Where(x => x.Active == true).OrderBy(x => x.Ordering).ToList();
            }
            else
            {
                List<BannerModel> nullBanner = new List<BannerModel>();
                this.Banners = nullBanner;
            }

            if (allEvent != null)
            {
                this.Events = allEvent.Where(x => x.EventStartDate >= DateTime.Today).OrderBy(x => x.EventStartDate).Take(3).Select(x => new EventDTO()
                {
                    EventID = x.EventID,
                    EventTitle = x.EventTitle,
                    EventDetail = x.EventDetail,
                    EventstartDay = x.EventStartDate.ToString("dd", CultureInfo.InvariantCulture),
                    EventStartMonth = x.EventStartDate.ToString("MMM", CultureInfo.InvariantCulture),
                    EventStartTime = x.EventStartDate.ToString("HH:mm", CultureInfo.InvariantCulture),
                    EventEndDay = x.EventEndDate.ToString("dd", CultureInfo.InvariantCulture),
                    EventEndMonth = x.EventEndDate.ToString("MMM", CultureInfo.InvariantCulture),
                    EventEndTime = x.EventEndDate.ToString("HH:mm", CultureInfo.InvariantCulture),
                }).ToList();
            }
            else
            {
                List<EventDTO> nullEvent = new List<EventDTO>();
                this.Events = nullEvent;
            }
        }
    }
}
