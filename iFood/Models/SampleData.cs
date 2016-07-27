﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace iFood.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<restaurantContext>
    {
         protected override void Seed(restaurantContext context)
    {
            var types = new List<FoodTypeModels>
        {
            new FoodTypeModels { Name = "Appetizer"},
            new FoodTypeModels { Name = "Main Course" },
            new FoodTypeModels { Name = "Desserts" },
        };

            new List<FoodItemModels>
            {
                new FoodItemModels {Name = "Bruschetta with Tomato and Basil",description="Home made Bruschetta with a special house made Tomato and Basil Souce, and spices from the east", Price=8.99M, FoodType = types.Single(g => g.Name == "Appetizer"), FoodArtUrl = "/Content/Images/BrushettaWithTomatoAndBasil.png" },
                new FoodItemModels {Name = "Spanish Tortilla", description="Thinly fried sliced of potatoes  mixed with vegetables, onion and multiple spices soaked in a stirred egg and cut into small cubes", Price=10.25M, FoodType = types.Single(g => g.Name == "Appetizer"), FoodArtUrl = "/Content/Images/small-bites-spanish-tortilla.jpg" },
                new FoodItemModels {Name = "Fried Pork Dumplings", description = "Pork, Bacon, cabbage and multiple spices wrapped up in a Dumpling form, served with ponzu dipping souce", Price=10.99M, FoodType= types.Single(g => g.Name == "Appetizer"), FoodArtUrl = "/Content/Images/Fried-Pork-Dumplings.jpg" },
                new FoodItemModels {Name = "Skillet Chicken and Ravioli", description ="Seasoned chicken  mixed with classic ravioli, mushrooms, tomatoes, and parmesan all stir fryed in a skillet with in house seasoning", Price=23.55M, FoodType= types.Single(g => g.Name == "Main Course"), FoodArtUrl="/Content/Images/Skillet-Ravioli.jpg" }

            };
    }
    }
}