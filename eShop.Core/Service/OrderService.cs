using eShop.Core.Entities;
using eShop.Core.Interfaces.Repository;
using eShop.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        private IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository) : base(OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }
    }
}