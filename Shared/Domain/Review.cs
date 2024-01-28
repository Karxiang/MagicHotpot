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