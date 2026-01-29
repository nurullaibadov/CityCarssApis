using CityCars.Domain.Entities.Common;
using CityCars.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Booking : BaseEntity
    {
        public string BookingNumber { get; set; } = string.Empty; // Unique booking reference

        // Relationships
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public int PickupLocationId { get; set; }
        public int DropoffLocationId { get; set; }

        // Dates
        public DateTime PickupDate { get; set; }
        public DateTime DropoffDate { get; set; }
        public int TotalDays { get; set; }

        // Pricing
        public decimal CarDailyPrice { get; set; }
        public decimal CarTotalPrice { get; set; }
        public decimal InsuranceTotalPrice { get; set; }
        public decimal ExtrasTotalPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Deposit { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        // Extras
        public bool HasInsurance { get; set; }
        public bool HasExtraDriver { get; set; }
        public int ChildSeats { get; set; }
        public bool HasGPS { get; set; }
        public bool HasWiFi { get; set; }

        // Driver Info
        public string DriverName { get; set; } = string.Empty;
        public string DriverLicenseNumber { get; set; } = string.Empty;
        public string ExtraDriverName { get; set; } = string.Empty;
        public string ExtraDriverLicenseNumber { get; set; } = string.Empty;

        // Status
        public BookingStatus Status { get; set; } = BookingStatus.Pending;
        public string Notes { get; set; } = string.Empty;
        public string CancellationReason { get; set; } = string.Empty;
        public DateTime? CancelledAt { get; set; }

        // Actual rental info
        public DateTime? ActualPickupDate { get; set; }
        public DateTime? ActualDropoffDate { get; set; }
        public int? StartMileage { get; set; }
        public int? EndMileage { get; set; }
        public int? ActualKmDriven { get; set; }

        // Navigation Properties
        public virtual Customer Customer { get; set; } = null!;
        public virtual Car Car { get; set; } = null!;
        public virtual Location PickupLocation { get; set; } = null!;
        public virtual Location DropoffLocation { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual Review? Review { get; set; }
    }
}
