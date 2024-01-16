using FullSD.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public int? BookPartySize { get; set; }
        public string? BookDiningType { get; set; }
        public string? BookAddNote { get; set; }
        public virtual Customer? Customer { get; set; }
        public int? CustomerId {  get; set; }
        public virtual Branch? Branch { get; set; }
        public int? BranchId { get; set; }
        public virtual Staff? Staff { get; set; }

    }
}
//        public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }