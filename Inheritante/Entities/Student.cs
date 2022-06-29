using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritante.Entities
{
    public class Student : BaseEntity
    {
        [Range(0, 10)]
        public int AverageRate { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public string University { get; set; }

    }
}
