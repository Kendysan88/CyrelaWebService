using System;

namespace VivazAPI.Domain
{
    public interface IOccurrenceInWarranty
    {
        bool IsOccurreceInWarranty(int WarrantyPeriodInYears, DateTime InspectionDate);
    }
}
