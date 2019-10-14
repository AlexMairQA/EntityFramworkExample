using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PostgreCodeFirst
{
    public class Car
    {
        [Key]
        public string LicenceNumber { get; set; }
        public string Make { get; set; }
        public int? Year { get; set; }

    }
}
