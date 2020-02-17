﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IServiceProduct
    {
        void AddProduct(Product p);
        void RemoveProduct(Product p);
    }
}