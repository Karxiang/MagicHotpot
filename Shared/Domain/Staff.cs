using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffIcNo { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPostion { get; set; }
        public int? StaffPhoneNo { get; set; }
        public DateTime? StaffDOB { get; set; }
        public DateTime? StaffJoinDate { get; set; }

        public virtual Branch? Branch { get; set; }
        public int? BranchId { get; set; }
    }
}
//public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }