using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreForDemoWithLogin.Models
{
    public class LinkModel
    {
        [Key]
        public int LinkID { get; set; }

        public string LinkName { get; set; }

        public string URL { get; set; }
    }
}
