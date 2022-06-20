﻿using ECommerceDemo.Application.Abstractions;
using ECommerceDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new() 
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Product 1",
                    Price = 100,
                    Stock = 50
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Product 2",
                    Price = 200,
                    Stock = 40
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Product 3",
                    Price = 300,
                    Stock = 30
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Product 4",
                    Price = 400,
                    Stock = 20
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Product 5",
                    Price = 500,
                    Stock = 10
                }
            };
    }
}