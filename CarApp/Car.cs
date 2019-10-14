using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarApp
{
    public class Car
    {
        [Key]
        public string LicenceNo { get; set; }
        public string Make { get; set; }
        public int? Year { get; set; }

        public override string ToString()
        {
            return LicenceNo;
        }

    }
}
