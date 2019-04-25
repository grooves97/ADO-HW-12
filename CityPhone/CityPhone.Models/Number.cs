using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityPhone.Models
{
    public class Number : Entity
    {
        public int PhoneNumber { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
    }
}
