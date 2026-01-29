using CityCars.Domain.Entities.Common;
using CityCars.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Car : BaseEntity
    {
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int CategoryId { get; set; }

        public string PlateNumber { get; set; } = string.Empty;
        public string VIN { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;

        // Specifications
        public int Seats { get; set; }
        public int Doors { get; set; }
        public TransmissionType Transmission { get; set; }
        public FuelType FuelType { get; set; }
        public decimal FuelConsumption { get; set; } // L/100km

        // Features
        public bool HasAirConditioning { get; set; }
        public bool HasGPS { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasUSBPort { get; set; }
        public bool HasParkingSensor { get; set; }
        public bool HasReverseCamera { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasLeatherSeats { get; set; }

        // Pricing
        public decimal DailyPrice { get; set; }
        public decimal WeeklyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }
        public decimal Deposit { get; set; }

        // Insurance
        public decimal InsuranceDailyPrice { get; set; }
        public decimal ExtraDriverDailyPrice { get; set; }
        public decimal ChildSeatDailyPrice { get; set; }

        // Limits
        public int DailyKmLimit { get; set; }
        public decimal ExtraKmPrice { get; set; }

        // Status
        public CarStatus Status { get; set; } = CarStatus.Available;
        public int Mileage { get; set; }
        public string Notes { get; set; } = string.Empty;
        public bool IsFeatured { get; set; } = false;

        // Rating
        public decimal AverageRating { get; set; }
        public int TotalReviews { get; set; }

        // Navigation Properties
        public virtual Brand Brand { get; set; } = null!;
        public virtual Model Model { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<CarImage> Images { get; set; } = new List<CarImage>();
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
