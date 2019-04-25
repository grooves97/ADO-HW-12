using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityPhone.Models
{
    public class City : Entity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public virtual ICollection<Number> Numbers { get; set; }
    }
}