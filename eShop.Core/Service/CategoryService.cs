using eShop.Core.Entities;
using eShop.Core.Interfaces;
using eShop.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        private ICategoryRepository _CategoryRepository;

        public CategoryService(ICategoryRepository CategoryRepository) : base(CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }
    }
}