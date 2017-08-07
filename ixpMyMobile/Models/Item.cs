using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ixpMyMobile.Models
{
    public class Item
    {

        public int ItemId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public int ClientId { get; set; }

        public int Count { get; set; }
        public String Condition { get; set; }
    }
}