using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string NameSurname { get; set; }

        public string Email { get; set; }


        public string Subject { get; set; }


        public string Mesaj { get; set; }
    }
}