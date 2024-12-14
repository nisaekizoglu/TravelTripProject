using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public string Navigation { get; set; }
    }
}