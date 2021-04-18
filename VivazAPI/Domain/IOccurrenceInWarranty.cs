using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Domain
{
    public interface IOccurrenceInWarranty
    {
        bool IsOccurreceInWarranty(int WarrantyPeriodInYears, DateTime InspectionDate);
    }
}
