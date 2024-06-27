using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        public string User {  get; set; }

        public string Email { get; set; }

        public string comment { get; set; }

        public int Blogid { get; set; }


        public virtual Blog Blog { get; set; }
        }
    }
