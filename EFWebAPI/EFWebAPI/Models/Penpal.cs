using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFWebAPI.Models
{
    public class Penpal
    { 
        public int Id { get; set; }
        [Required]
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string StreetAddy
        {
            get; set;
        }
        public string CityStateZip
        {
            get; set;
        }

        // Foreign Key
        public int PenpalId { get; set; }
        // Navigation Property
        public Penpal Penpals
        {
            get; set;
        }
    }
}