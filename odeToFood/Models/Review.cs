using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class Review
    {
        public int Id { get; set; }
      

        public int Rating { get; set; }

        public string Body { get; set; }

        public int RestaurantId { get; set; }

        public string ReviewerName { get; set; }
    }
}