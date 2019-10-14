using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarApp
{
    public class CarContext
        :DbContext
    {
        public CarContext() : base(nameOrConnectionString: "Default") { }

        public DbSet<Car> Cars { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
