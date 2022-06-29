using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritante.Entities
{
    public class Employee : BaseEntity
    {
        public int Age { get; set; }

        public string Company { get; set; }
    }
}
