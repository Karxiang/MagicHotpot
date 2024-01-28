using FullSD.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class Food : BaseDomainModel 
    {

        public string? FoodName { get; set; }
        public string? FoodDescription { get; set; }
        public double? FoodPrice { get; set; }
    }
}
