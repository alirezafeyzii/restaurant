using Microsoft.EntityFrameworkCore;
using Restaurant1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant1.Repository
{
    public class OrderRepository
    {
        public List<Order> Gets()
        {
            using var context = new ResturantContext();

            return context.Orders.Include(p => p.OrderDetails).ThenInclude(o => o.FoodType).ToList();
        }
        public Order Get(int id)
        {
            using var context = new ResturantContext();

            return context.Orders.Include(p => p.OrderDetails).ThenInclude(o => o.FoodType).First(p => p.Id == id);
        }
        public void Add(Order order)
        {
            using var context = new ResturantContext();
            List<FoodType> foodTypes = new List<FoodType>();
            foreach (var orderDetail in order.OrderDetails)
            {
                foodTypes.Add(orderDetail.FoodType);
                orderDetail.FoodType = null;
            }
            context.Add(order);
            for (int i = 0; i < order.OrderDetails.Count; i++)
            {
                order.OrderDetails[i].FoodType = foodTypes[i];
            }
            context.SaveChanges();
        }
    }
}
