using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.Builder.Foods
{
    using Items;
    class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var vegMeal = new Meal();
            vegMeal.AddItem(new VegBurger());
            vegMeal.AddItem(new Coke());
            return vegMeal;
        }

        public Meal PrepareNonVegMeal()
        {
            var nonVegMeal = new Meal();
            nonVegMeal.AddItem(new ChickenBurger());
            nonVegMeal.AddItem(new Pepsi());
            return nonVegMeal;
        }
    }
}
