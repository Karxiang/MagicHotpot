using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage ="Name is too short")]
        public string? CustomerName {  get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email Address is invalid")]
        [EmailAddress]
		public string? CustomerEmail { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage ="Invalid Phone Number(must start with 6, 8 or 9)")]
        public int? CustomerPhoneNo { get; set;}

		public string? CustomerAddress { get; set; }
        public DateTime? CustomerDOB { get; set; }
        public DateTime? CustomerJoinDate { get; set; } = DateTime.Now;

    }
}
////public int? OrderQty {  get; set; }

//public virtual Food? Food { get; set; }