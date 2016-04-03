using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdimRic841PipingCharVV.Models
{
    public class DataCmDb: DbContext
    {
        public DataCmDb(): base("DefaultConnection")
        {
        }

        public DbSet <FunctionalLocationModel> FunctionalLocations { get; set; }

        public DbSet<TargetedUnitModel> TargetedUnits { get; set; }
    }
}