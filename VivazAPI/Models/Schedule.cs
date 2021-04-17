using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Dtos;

namespace VivazAPI.Models
{
    public class Schedule : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid EmployeeId { get; set; }
        public User Employee { get; set; }
        public Guid OccurenceId { get; set; }
        //public Occurence Occurence { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}
