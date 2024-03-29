﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {

        //public string? OrderItemID {  get; set; }
        [Required]
		[Range(1, 20, ErrorMessage = "Order Quantity must be between 1 and 20.")]
		public int? OrderQty {  get; set; }
        public virtual Food? Food { get; set; }
        public int FoodID { get; set; }
        public virtual Booking? Booking { get; set; }
        public int BookID { get; set; }
    }
}
