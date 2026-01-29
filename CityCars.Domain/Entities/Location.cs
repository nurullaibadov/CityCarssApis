using CityCars.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // Baku Airport, City Center, etc.
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = "Azerbaijan";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<Booking> PickupBookings { get; set; } = new List<Booking>();
        public virtual ICollection<Booking> DropoffBookings { get; set; } = new List<Booking>();
    }
}
