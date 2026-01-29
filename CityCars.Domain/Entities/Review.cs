using CityCars.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Review : BaseEntity
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }

        public int Rating { get; set; } // 1-5
        public string Title { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        // Sub-ratings
        public int CleanlinessRating { get; set; }
        public int ComfortRating { get; set; }
        public int PerformanceRating { get; set; }
        public int ValueRating { get; set; }

        public bool IsApproved { get; set; } = false;
        public bool IsFeatured { get; set; } = false;
        public DateTime? ApprovedAt { get; set; }

        // Response from admin
        public string AdminResponse { get; set; } = string.Empty;
        public DateTime? RespondedAt { get; set; }

        // Navigation Properties
        public virtual Booking Booking { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Car Car { get; set; } = null!;
    }
}
