using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class Restaurant
    {

        public int id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}