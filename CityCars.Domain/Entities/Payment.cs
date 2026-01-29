using CityCars.Domain.Entities.Common;
using CityCars.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }

        public string TransactionId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "AZN";
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public string PaymentMethod { get; set; } = string.Empty; // Card, Cash, Bank Transfer

        // Card info (if applicable)
        public string CardLastFourDigits { get; set; } = string.Empty;
        public string CardBrand { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public DateTime? PaidAt { get; set; }
        public string FailureReason { get; set; } = string.Empty;

        // Navigation Properties
        public virtual Booking Booking { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}
