using FullSD.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace FullSD.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        [Required]
		[Range(1, 12, ErrorMessage = "Party size must be between 1 and 12.")]

		public int? BookPartySize { get; set; }
		[Required]
		[RegularExpression("^(DineIn|DineOut|1|2|in|In|out|Out|Dine In|Dine Out)$", ErrorMessage = "Invalid dining type.")]
		public string? BookDiningType { get; set; }
        public string? BookAddNote { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime? BookDate { get; set; }
		public string? BookTime { get; set; }
		public virtual Customer? Customer { get; set; }
		[Required]
        public int? CustomerId {  get; set; }
        public virtual Branch? Branch { get; set; }
		[Required]
        public int? BranchId { get; set; }
        public virtual Staff? Staff { get; set; }
		[Required]
        public int? StaffId { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			throw new NotImplementedException();
		}
	}
}
//        public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }