﻿using System;
using System.Collections.Generic;
using System.Text;
using TheAmazingQuickBuy.Domain.Entities;
using TheAmazingQuickBuy.Domain.Interfaces.Repositories;

namespace TheAmazingQuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository()
        {

        }
    }
}