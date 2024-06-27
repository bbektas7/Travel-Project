using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class BlogComment
    {
        // IEnumerable ile birden fazla tablodan değer çekebiliyor olucam.
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Comments> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }

    }
}