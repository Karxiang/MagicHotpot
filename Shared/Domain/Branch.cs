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
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set;}
        public int? BranchCapacity { get; set; }
        public int? BranchPhoneNo { get; set;}

    }
}
//public int? OrderQty {  get; set; }
//public virtual Food? Food { get; set; }