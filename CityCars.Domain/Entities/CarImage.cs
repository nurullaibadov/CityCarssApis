using CityCars.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{

    public class CarImage : BaseEntity
    {
        public int CarId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string PublicId { get; set; } = string.Empty; // Cloudinary public ID
        public bool IsPrimary { get; set; } = false;
        public int DisplayOrder { get; set; }

        // Navigation Properties
        public virtual Car Car { get; set; } = null!;
    }
}
