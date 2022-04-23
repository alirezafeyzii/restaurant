using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant1.Models
{
    public class OrderDetail:BaseClass
    {
        /// <summary>
        /// جزیات سفارش
        /// </summary>
        public OrderDetail(FoodType foodType, decimal count)
        {
            FoodType = foodType;
            Count = count;
        }
        public FoodType FoodType { get; set; }
        public decimal Count { get; set; }
        public OrderDetail() { }
    }
}
