using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class BlogComment
    {

        public IEnumerable<Blog> values1 { get; set; }
        public IEnumerable<Comment> values2 { get; set; }
        public IEnumerable<Blog> values3 { get; set; }

    }
}