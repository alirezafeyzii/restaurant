using Restaurant1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant1.Repository
{
    public class FoodTypeRepository
    {
        public List<FoodType> Gets()
        {
            using var context = new ResturantContext();

            return context.FoodTypes.ToList();
        }
        public FoodType Get(int id)
        {
            using var context = new ResturantContext();

            return context.FoodTypes.First(p => p.Id == id);
        }
        public void Add(FoodType food)
        {
            using var context = new ResturantContext();
            context.Add(food);
            context.SaveChanges();
        }
    }
}
