using eShop.Core.Entities;
using eShop.Core.Interfaces.Repository;
using eShop.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private IProductRepository _ProductRepository;

        public ProductService(IProductRepository ProductRepository) : base(ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
    }
}