using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class OdetoFoodDb : DbContext
    {
        public OdetoFoodDb() : base("name=mydb")
        {

        }
        public DbSet<Restaurant> Restarants { get; set; }

        public DbSet<Review> Reviews { get; set; }


    }
}