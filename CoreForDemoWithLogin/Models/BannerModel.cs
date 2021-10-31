using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreForDemoWithLogin.Models
{
    public class BannerModel
    {
        [Key]
        public int BannerID { get; set; }

        public string BannerTitle { get; set; }

#nullable enable
        public string? BannerDescription { get; set; }

        public string? URL { get; set; }
#nullable disable
        public string ImgLink { get; set; }


        public int Ordering { get; set; }

        public bool Active { get; set; }

        public bool ShowTitle { get; set; }
    }
}
