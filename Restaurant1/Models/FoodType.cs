using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant1.Models
{
    public class FoodType:BaseClass
    {
        public FoodType(string name,decimal amount)
        {
            Name = name;
            Amount = amount;
        }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        private FoodType() { }
    }
}
