using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivazAPI.Dtos
{
    public class ActivityTypeReadDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int WarrantyInYears { get; set; }
       
    }
}
