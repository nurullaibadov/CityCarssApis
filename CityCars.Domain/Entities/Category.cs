using CityCars.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // Economy, Luxury, SUV, etc.
        public string Description { get; set; } = string.Empty;
        public string IconUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
