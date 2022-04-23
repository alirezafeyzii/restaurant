using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant1.Models
{
    public class Order:BaseClass
    {
        public Order(List<OrderDetail> orderDetails)
        {
            this.OrderDetails = orderDetails;
        }
        public string OrderDescription => GenerateDescription();
        public decimal FinallyAmount => OrderDetails.Sum(p => p.FoodType.Amount * p.Count);
        public List<OrderDetail> OrderDetails { get; private set; }
        private string GenerateDescription()
        {
            string result = "";
            foreach (var orderDetail in OrderDetails)
            {
                result += orderDetail.Count + " " + orderDetail.FoodType.Name + "";
            }
            return result;
        }
        private Order()
        {

        }
    }
}
