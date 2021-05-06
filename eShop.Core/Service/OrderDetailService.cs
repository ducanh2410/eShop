using eShop.Core.Entities;
using eShop.Core.Interfaces.Repository;
using eShop.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class OrderDetailService : BaseService<OrderDetail>, IOrderDetailService
    {
        private IOrderDetailRepository _OrderDetailRepository;

        public OrderDetailService(IOrderDetailRepository OrderDetailRepository) : base(OrderDetailRepository)
        {
            _OrderDetailRepository = OrderDetailRepository;
        }
    }
}