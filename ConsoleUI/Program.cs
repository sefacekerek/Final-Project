﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger( new EfProductDal());
            foreach (var product in productManeger.GetAll() )
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
