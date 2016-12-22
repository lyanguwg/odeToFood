using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class Review
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String City { get; set; }

        public String Country { get; set; }

        public int Rating { get; set; }
    }
}