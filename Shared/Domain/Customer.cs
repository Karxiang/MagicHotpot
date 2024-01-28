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
        public string? CustomerName {  get; set; }
        public string? CustomerEmail { get; set; }
        public int? CustomerPhoneNo { get; set;}
        public string? CustomerAddress { get; set; }
        public DateTime? CustomerDOB { get; set; }
        public DateTime? CustomerJoinDate { get; set; }

    }
}
////public int? OrderQty {  get; set; }

//public virtual Food? Food { get; set; }