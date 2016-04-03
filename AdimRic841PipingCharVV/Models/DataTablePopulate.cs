using AdimRic841PipingCharVV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AdimRic841PipingCharVV.Models
{
    public class DataTablePopulate
    {
        public static void PopulateFunctionalLocationTable()
        {
            using (var db = new DataCmDb())
            {   
                /* 
                db.FunctionalLocations.Add(new FunctionalLocationModel
                {
                    LocationId = "0101-001-001",
                    Unit = "0101",
                    BusinesssArea = "1CF",
                    ApiPipeClass = "1",
                    RefineryPipeClass = "AF1(N1)",
                    PipingMaterial = "CS"

                });
                
                db.TargetedUnits.Add(new TargetedUnitModel
                {
                    Id = 1,
                    Unit = "0101"
                });
                */
                db.SaveChanges();
            }//using

        }
        
    }
}