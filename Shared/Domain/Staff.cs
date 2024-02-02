using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Staff : BaseDomainModel
    {

		[Required]
		[RegularExpression(@"^[STFQstfg]\d{7}[A-Za-z]", ErrorMessage = "Driving License does not meet NRIC requirements")]
		public string? StaffIcNo { get; set; }
        [Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "Name is too short")]

		public string? StaffName { get; set; }
        [Required]
        public string? StaffPostion { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Invalid Phone Number")]
		public int? StaffPhoneNo { get; set; }

        public DateTime? StaffDOB { get; set; }

        public DateTime? StaffJoinDate { get; set; } = DateTime.Today;

        public virtual Branch? Branch { get; set; }
        public int? BranchId { get; set; }
    }
}
//public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }