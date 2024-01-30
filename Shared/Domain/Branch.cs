using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Branch : BaseDomainModel
    {
		[Required(ErrorMessage = "BranchName is missing")]
        public string? BranchName { get; set; }
        [Required(ErrorMessage ="Address is missing")]
        public string? BranchAddress { get; set;}
        [Required]
		[Range(1, 120, ErrorMessage = "Capacity size must be between 1 and 120.")]

		public int? BranchCapacity { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Invalid Phone Number")]
		public int? BranchPhoneNo { get; set;}

    }
}
//public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }