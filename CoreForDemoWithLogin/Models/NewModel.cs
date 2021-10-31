using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreForDemoWithLogin.Models
{
    public class NewModel
    {
        [Key]
        public int NewID { get; set; }

        public string NewName { get; set; }

        public string NewDetail { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ActiveDate { get; set; }
    }
}
