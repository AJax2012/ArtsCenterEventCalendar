using System.ComponentModel.DataAnnotations;

namespace ArtsCenterEventCalendar.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}