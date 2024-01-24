using FullSD.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FullSD.Server.Configurations.Entities
{
    public class FoodSeedConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
            new Food
            {
                Id = 1,
                FoodName = "Sliced Fish",
                FoodPrice = 11.30
            },
            new Food
            {
                Id= 2,
                FoodName = "Chicken Slices",
                FoodPrice = 8.30
            },
            new Food
            {
                Id = 3,
                FoodName = "Beef Slices",
                FoodPrice = 11.90
            },
            new Food
            {
                Id = 4,
                FoodName = "Cheese Tofu",
                FoodPrice = 5.95
            },
            new Food
            {
                Id = 5,
                FoodName = "Fish Cured",
                FoodPrice = 5.95
            },
            new Food
            {
                Id = 6,
                FoodName = "Sliced Pork Belly",
                FoodPrice = 11.90
            },
            new Food
            {
                Id = 7,
                FoodName = "Abalone",
                FoodPrice = 29.70
            },
            new Food
            {
                Id = 8,
                FoodName = "Prawn",
                FoodPrice = 10.70
            },
            new Food
            {
                Id = 9,
                FoodName = "Pork Meatball",
                FoodPrice = 8.90
            },
            new Food
            {
                Id = 10,
                FoodName = "Fishball",
                FoodPrice = 5.95
            },
            new Food
            {
                Id = 11,
                FoodName = "Quail Eggs",
                FoodPrice = 7.15
            },
            new Food
            {
                Id = 12,
                FoodName = "Golden Enoki Mushrooms",
                FoodPrice = 6.55
            },
            new Food
            {
                Id = 13,
                FoodName = "Sweet Corn",
                FoodPrice = 4.75
            },
            new Food
            {
                Id = 14,
                FoodName = "Radish",
                FoodPrice = 3.00
            },
            new Food
            {
                Id = 15,
                FoodName = "Black Fungus",
                FoodPrice = 4.20
            },
            new Food
            {
                Id = 16,
                FoodName = "Lettuce",
                FoodPrice = 4.75
            },
            new Food
            {
                Id = 17,
                FoodName = "Cabbage",
                FoodPrice = 4.75
            },
            new Food
            {
                Id = 18,
                FoodName = "Spinach",
                FoodPrice = 4.75
            },
            new Food
            {
                Id = 19,
                FoodName = "Beencurd Rolls",
                FoodPrice = 7.70
            },
            new Food
            {
                Id = 20,
                FoodName = "Instant Noodles",
                FoodPrice = 2.40
            }
            );
        }
    }
}
