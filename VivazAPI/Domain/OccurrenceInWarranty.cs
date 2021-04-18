using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Domain
{
    public class OccurrenceInWarranty : IOccurrenceInWarranty
    {
        public bool IsOccurreceInWarranty(int WarrantyPeriodInYears, DateTime InspectionDate)
        {
            return InspectionDate.AddYears(WarrantyPeriodInYears).Year <= DateTime.Now.Year;
        }
    }
}
