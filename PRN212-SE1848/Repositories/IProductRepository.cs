﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface IProductRepository
    {
        public void GenerateSampleDataset();
        public List<Product> GetProducts();
        public bool SaveProduct(Product product);
        public Product GetProduct(int id);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int id);
        public bool DeleteProduct(Product product);



    }
}
