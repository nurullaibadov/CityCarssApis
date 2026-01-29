using CityCars.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCars.Domain.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public int Year { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual Brand Brand { get; set; } = null!;
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
