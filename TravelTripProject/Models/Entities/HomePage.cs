﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class HomePage
    {
        [Key]
        public int HomePageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}