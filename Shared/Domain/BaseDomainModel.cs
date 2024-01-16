using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime? BookDate { get; set; }
        public DateTime? BookTime { get; set; }
    }
}
