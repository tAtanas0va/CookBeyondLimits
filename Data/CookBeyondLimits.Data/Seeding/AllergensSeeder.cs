﻿namespace CookBeyondLimits.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using CookBeyondLimits.Services.Data.Allergens;

    using Microsoft.Extensions.DependencyInjection;

    internal class AllergensSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Allergens.Any())
            {
                return;
            }

            var allergenService = serviceProvider.GetRequiredService<IAllergensService>();

            var allergenNames = new string[]
            {
                "Milk",
                "Eggs",
                "Fish",
                "Crustaceans",
                "Tree nuts",
                "Peanuts",
                "Wheat",
                "Soybeans",
                "Gluten",
                "Sesame",
            };

            await allergenService.CreateAllAsync(allergenNames);
        }
    }
}
