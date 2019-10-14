using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PostgreCodeFirst
{
    public class CarContext
        : DbContext
    {

        public DbSet<Car> Cars;



        
    }
}
