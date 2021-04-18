using System;

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
