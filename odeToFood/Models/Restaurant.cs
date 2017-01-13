using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class Restaurant
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        //adding virtual mades EF perform implicit loading when Reviews are needed
        public virtual ICollection<Review> Reviews { get; set; }
    }
}