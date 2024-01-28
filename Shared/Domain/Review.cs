using FullSD.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        [Required]
		[Range(0, 5, ErrorMessage = "Invalid rating! Please enter 0-5 (0 - Worst, 5 - Best)")]
		public int? ReviewRating { get; set; }
        public string? ReviewDescription { get; set; }

        public virtual Customer? Customer { get; set; }
        public int? CustomerId { get; set; }
        public virtual Booking? Booking { get; set; }
        public int? BookingId { get;set; }
    }
}
//public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }