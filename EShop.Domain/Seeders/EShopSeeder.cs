﻿using EShop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Domain.Models

namespace EShop.Domain.Seeders
{
    public class EShopSeeder(DataContext context) : IEShopSeeder
    {
        public async Task Seed()
        {
            if (!context.Products.Any())
            {
                var students = new List<Product>
                {
                    new Product { Name = "Cobi", Ean = "1234" },
                    new Product { Name = "Duplo", Ean = "431" },
                    new Product { Name = "Lego", Ean = "12212" }
                };
                context.Products.AddRange(students);
                context.SaveChanges();
            }
        }
    }
}
