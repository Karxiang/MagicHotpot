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
		[Required(ErrorMessage = "Food Name is missing")]

		public string? FoodName { get; set; }
        public string? FoodDescription { get; set; }
		[Required]
		[Range(0.01, 120.0, ErrorMessage = "Price must be between 0.01 and 120.0")]
		public double? FoodPrice { get; set; }
    }
}
