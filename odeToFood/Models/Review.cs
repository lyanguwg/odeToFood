﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class Review
    {
        public int Id { get; set; }
      
        [Range(1,10)]
        [Required]
        public int Rating { get; set; }
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        public int RestaurantId { get; set; }

        [Display(Name ="User Name")]
        [DisplayFormat(NullDisplayText ="Anonymous")]
        public string ReviewerName { get; set; }
    }
}