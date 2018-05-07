﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPriceCalculator.Domain.Entities;

namespace MiniPriceCalculator.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}